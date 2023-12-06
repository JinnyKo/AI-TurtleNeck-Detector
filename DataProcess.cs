using OpenCvSharp.Internal.Vectors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pose_Detection
{
    internal class DataProcess
    {
        public List<int> grade = new List<int>();
        public double[] User_point; 
        public double[] Good_point;

        public double shoulder_slope; //찍어보게 

        //정수리, 눈 (L, R), 코 끝, 인중, 턱 끝, 밑 목, 가슴 중앙, 어깨 (L, R)
        //Grade 0 이면 탐지 불가 
        struct Keypoints
        {
            public double Head_x; //0
            public double Head_y; //1
            public double LEye_x; //2
            public double LEye_y; //3
            public double REye_x; //4
            public double REye_y; //5
            public double Nose_x; //6
            public double Nose_y; //7
            public double Philtrum_x; //8
            public double Philtrum_y; //9
            public double Chin_x; //10
            public double Chin_y; //11
            public double Neck_x; //12
            public double Neck_y; //13
            public double Mid_x; //14
            public double Mid_y; //15
            public double LShoulder_x; //16
            public double LShoulder_y; //17
            public double RShoulder_x; //18
            public double RShoulder_y; //19 
        };

        public double[] Cal_Keypopints(string path)
        {
            //데이터 읽기 index 순서 대로 
            string filePath = path;
            string[] lines = File.ReadAllLines(filePath);
            string[] values = lines[0].Split(',');
            double[] data = new double[values.Length];
           
            for (int i = 0; i < values.Length; i++)
            {
                if (i < 20 && values[i] != null)
                {
                    values[i] = Regex.Replace(values[i], @"[^\d.]", "");
                }
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (double.TryParse(values[i], out double parsedValue))
                {
                    data[i] = parsedValue;
                }
            }
            return data;
        }
        public void Save_GoodPose(string data_path)
        {
            Good_point = Cal_Keypopints(data_path);
        }
        public int Cal_UserPose(string data_path)
        {
            User_point = Cal_Keypopints(data_path);
            int grade = -1;
            if (User_point.Length == 20)
            {
                //grade -1:탐지불가 1:바름  0:어깨 틀어짐 2:거북목 

                //1. 양 어깨 사이 기울기 p(16,17,18,19) 
                shoulder_slope = Cal_Slope(User_point[16], User_point[17], User_point[18], User_point[19]);
                if (shoulder_slope != -1)
                {
                    if (0.05 < shoulder_slope)
                        grade = 0;
                    else grade = 1;
                }
            }
            else //완벽한 예외 처리 아님 
            {
                grade = 2;
            }
            return grade;
        }
        private double Cal_Slope(double p1x, double p1y, double p2x, double p2y)
        {
            if (p1x == 0 || p1y == 0 || p2x == 0 || p2y == 0)
                return -1;

            if (p1x == p2x)
            {
                return 0;
            }
            return Math.Abs((p1y - p2y) / (p1x - p2x));
        }
        private double Cal_chin_y( double p1y, double p2y)
        {
            return (p2y/p1y);
        } 
    }
}

