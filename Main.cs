using OpenCvSharp;
using System.Management;
//using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using DirectShowLib;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Python.Runtime;
using System.Reflection;
using Python.Included;
using OpenCvSharp.Internal.Vectors;

namespace Pose_Detection
{
 
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Camera camera = new Camera();
        DataProcess dp = new DataProcess();
        int selectedIndex = -1;
        bool Connected;
        bool IsGoodPoseSaved = false; 
        private bool isCapturing = false;
        private bool isRunning = false;
        private Thread captureThread;
        private string Mode = "None";
        private List<int> alarm = new List<int>();
        int num = 0;
        string GoodPose_keypoint_path = Path.Combine(Application.StartupPath, "KeyPoints","GoodPose", "result_points.csv");
        string UserPose_keypoint_path = Path.Combine(Application.StartupPath, "KeyPoints", "UserPose", "result_points.csv");


        string savePath = Path.Combine(Application.StartupPath, "UserPose", "image");
        string scriptPath = Path.Combine(Application.StartupPath, "main.py");
        string pythonExe = Path.Combine(Application.StartupPath, "python.exe");

        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        List<int> pose = new List<int>();


        public Form1()
        {
            InitializeComponent();
            LoadCamereNames();
            DeleteFiles(GoodPose_keypoint_path); //기존 GoodPoints 들 삭제 
        }
        static void DeleteFiles(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] files = Directory.GetFiles(directoryPath);
                foreach (string filePath in files)
                {
                    File.Delete(filePath);
                }
            }
        }
        private void AddListViewItem(string val1, string val2, string val3, string val4)
        {
            listView_pose.Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(new string[] { val1, val2, val3, val4 });
                listView_pose.Items.Add(item);
            }));
        }
        static bool Count_Pose(List<int> list, int n, int targetValue)
        {
            int lastIndex = list.Count - 1;
            if (lastIndex < n - 1)
            {
                return false; // 아이템 수가 비교할 개수보다 작으면 비교할 수 없음
            }
            for (int i = lastIndex; i > lastIndex - n; i--)
            {
                if (list[i] != targetValue)
                {
                    return false; // 최근 n개의 값 중 다른 값이 있음
                }
            }
            return true; // 최근 n개의 값이 모두 targetValue와 같을 경우 true 반환
        }
      
        private void LoadCamereNames()
        {
            button_Pause.Enabled = false;
            button_start.Enabled = false;
            button_shoot.Enabled = false;
            button_ConnectCam.Enabled = false;
            List<string> cameraNames = new List<string>();

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%camera%'"))
            {
                foreach (ManagementObject camera in searcher.Get())
                {
                    string cameraName = camera["Name"] as string;
                    if (!string.IsNullOrEmpty(cameraName))
                    {
                        ComboBox_device.Items.Add(cameraName);
                    }
                }
            }
        }
        private void SelectCam(object sender, EventArgs e)
        {
            selectedIndex = ComboBox_device.SelectedIndex;
            button_ConnectCam.Enabled = true;
            button_ConnectCam.Text = "Connect";
        }
        private void button_ConnectCam_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1 && camera.ConectCam(selectedIndex))
            {
                Connected = true;
                button_ConnectCam.Text = "Connected";
                button_ConnectCam.Enabled = false;
                MessageBox.Show("어깨와 허리를 피고 Shoot 버튼을 눌러 나의 바른자세를 촬영 해 주세요!");
                button_Pause.Enabled = true;
                button_start.Enabled = true;
                button_shoot.Enabled = true;
                camera.CamOn(pictureBox_cam);
            }
            else
            {
                if (selectedIndex == -1)
                {
                    MessageBox.Show("Check the camera device");
                }
                else
                {
                    MessageBox.Show("Fail Connection");
                }
            }
        }
        private void Alarm()
       {
            var pose_num = dp.Cal_UserPose(UserPose_keypoint_path);
            pose.Add(pose_num);
            DateTime currentTime = DateTime.Now;
            int mode = find_mode();
            string[] poseTexts = { "어깨 틀어짐", "바른 자세", "거북목" };
            string PoseText = pose_num >= 0 && pose_num < poseTexts.Length ? poseTexts[pose_num] : "탐지 불가";
        
            AddListViewItem((num++).ToString(), currentTime.ToString(), PoseText, dp.shoulder_slope.ToString());
        
            if (pose.Count > 10)
            {
                pose.RemoveAt(0);
            }
        
            // 자세 불량 메시지 표시 로직을 함수로 추출
            CheckAndDisplayPoorPosture(mode, pose_num, "어깨 자세 불량", 0);
            CheckAndDisplayPoorPosture(mode, pose_num, "거북목 자세 불량", 2);
       }
         
         private void CheckAndDisplayPoorPosture(int mode, int pose_num, string message, int targetPose)
         {
             int[] modeThresholds = { 3, 5, 7 }; // H, M, W 모드에 따른 임계값
             string[] modeNames = { "H Mode", "M Mode", "W Mode" };
         
             if (mode >= 1 && mode <= 3)
             {
                 int threshold = modeThresholds[mode - 1];
                 if (Count_Pose(pose, threshold, targetPose))
                 {
                     MessageBox.Show($"{modeNames[mode - 1]}: {message}");
                 }
             }
         }
        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                MessageBox.Show("이미 실행 중입니다.");
                return;
            }
            //if (Mode == "None")
            //{
            //    MessageBox.Show("모드를 선택해 주세요");
            //    return;
            //}
            isCapturing = true;

            startInfo.FileName = pythonExe;
            startInfo.Arguments = scriptPath;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;

            Task.Run(() =>
            {
                while (isCapturing)
                {
                    string imagePath = Path.Combine(savePath, "UserPose.jpg");

                    if (pictureBox_cam.Image != null)
                    {
                        pictureBox_cam.Invoke((Action)(() =>
                        {
                            using (Bitmap bmp = new Bitmap(pictureBox_cam.Image))
                            {
                                using (MemoryStream memoryStream = new MemoryStream())
                                {
                                    bmp.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    File.WriteAllBytes(imagePath, memoryStream.ToArray());
                                }
                            }
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Device is not connected");
                    }
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (!IsGoodPoseSaved && Directory.Exists(GoodPose_keypoint_path))
                    {
                        dp.Save_GoodPose(GoodPose_keypoint_path);
                        IsGoodPoseSaved = true; 
                    }
                    else
                    {
                        Alarm();
                    }
                }
                isCapturing = false;
            });
        }
        private void button_pause_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                button_shoot.Enabled = true;
                isCapturing = false;
            }
            else MessageBox.Show("Device is not connected");
        }
        private void button_shoot_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                string savePath = System.Windows.Forms.Application.StartupPath + @"\GoodPose\image";
                string imagePath = Path.Combine(savePath, "goodPose.jpg");

                if (pictureBox_cam.Image != null)
                {
                    using (Bitmap bmp = new Bitmap(pictureBox_cam.Image))
                    {
                        bmp.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    MessageBox.Show("바른 자세 이미지가 저장 되었습니다.\n다시 찍으려면 Shoot 버튼을 누르세요.\n" +
                        "이 이미지로 진행을 원하시면 Start 버튼을 누르세요.");
                }
            }
            else MessageBox.Show("Device is not connected");
        }
        private void RadioCheckChange(object sender, EventArgs e)
        {
         
        }
        private int find_mode()
        {
            if (radioButton_H.Checked) { return 1; }
            else if (radioButton_M.Checked) { return 2; }
            else if (radioButton_W.Checked) { return 3; }
            else return 0;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 정리 및 리소스 해제
            camera.StopCapture(pictureBox_cam);
        }
    }
}
