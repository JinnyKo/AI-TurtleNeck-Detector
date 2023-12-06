using OpenCvSharp;
using DirectShowLib;
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
using System.IO;
using System.Threading;
using System.Timers;

namespace Pose_Detection
{
    internal class Camera

    {
        private VideoCapture video;
        public bool isCapturing = false;
        public bool captureButtonPressed = false; 
        private Bitmap MatToBitmap(Mat mat)
        {
            Cv2.ImEncode(".jpg", mat, out byte[] buffer);
            using (var memoryStream = new MemoryStream(buffer))
            {
                return new Bitmap(memoryStream);
            }
        }
        public bool ConectCam(int CamIndex)
        {
            try
            {
                video = new VideoCapture(CamIndex);
                video.FrameWidth = 640; //fixed size
                video.FrameHeight = 480;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the camera: " + ex.Message);
                return false;
            }

            //isCapturing = true;  
            return true;
        }
        public void CamOn(PictureBox picture)
        {
            if (isCapturing) return;
            isCapturing = true;
            while (isCapturing)
            {
                Mat frame = new Mat();
                video.Read(frame);
                if (frame.Empty())
                {
                    continue;
                }
                
                ShowFrame(frame, picture);
                Application.DoEvents(); 
                Thread.Sleep(10);
            }
            isCapturing = false;
           // Cv2.DestroyAllWindows();
        }
        public void StartCapture(PictureBox picture)
        {
            if (isCapturing) return;

            isCapturing = true;;

            while (isCapturing)
            {
                Mat frame = new Mat();
                video.Read(frame);

                if (frame.Empty()) //중간에 연결 끊겼을 때
                {
                    // 중간에 연결 끊겼을 때가 아니라 카메라로부터 이미지가 안들어온경우 (간헐적으로 발생함)
                    continue;
                }

                ShowFrame(frame, picture);

                //frame.Dispose();    // frame = 가장 마지막 가져온 이미지 데이터이므로 매 이미지 갱신시 마다 Dispose해줘야 함
                                     
                Application.DoEvents();
                Thread.Sleep(100);
            }

            string path = System.Windows.Forms.Application.StartupPath + @"\ImageTest\CamOff.jpg";
            picture.Load(path);

            //frame.Dispose();
            //video.Release();      // 비디오 릴리즈는 Disconnect할 때
            Cv2.DestroyAllWindows();
        }
        private void ShowFrame(Mat frame, PictureBox picture)
        {
            Bitmap bitmapFrame = MatToBitmap(frame);
            if (picture.InvokeRequired)
            {
                picture.Invoke((MethodInvoker)delegate
                {
                    picture.Image?.Dispose();       // 기존에 픽쳐박스에 있던 이미지 해제 (없으면 해제 안함)
                    picture.Image = bitmapFrame;
            
                    frame.Dispose();
                });
            }
            else
            {
                picture.Image?.Dispose();     
                picture.Image = bitmapFrame;
              
                frame.Dispose();
            }
        }
        public void StopCapture(PictureBox picture)
        {
            isCapturing = false;
        }
        private void SaveScreenshot(object sender, EventArgs e)
        {
            string screenshotPath = System.Windows.Forms.Application.StartupPath + @"\UserImage\";
            string fileName = $"InputImage_{DateTime.Now:yyyyMMddHHmmss}.jpg";
            string fullPath = Path.Combine(screenshotPath, fileName);

            Mat screenshot = new Mat();
            video.Read(screenshot);

            if (!screenshot.Empty())
            {
                screenshot.SaveImage(fullPath);
            }
        }


    }
}


