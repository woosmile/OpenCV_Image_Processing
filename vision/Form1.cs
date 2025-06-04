using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Threading;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace vision
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();

        private List<Mat> imageSrcList = new List<Mat>();
        private List<Mat> imageFilteredList = new List<Mat>();
        Mat filtered = new Mat();

        private Thread imageGrabThread;
        private bool isRunning = false;

        private bool isCameraOpen = false;
        private bool isFilterEnable = false;
        private int imageSelect = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageSrcList.Clear();

                foreach (string file in ofd.FileNames)
                {
                    imageSelect = 0;
                    imageSrcList.Add(new Mat(file));
                }

                Bitmap bmp = BitmapConverter.ToBitmap(imageSrcList[0]);
                BeforeImage.Image?.Dispose();
                BeforeImage.Image = bmp;
                BeforeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (imageSelect > 0)
            {
                imageSelect--;

                Bitmap bmp = BitmapConverter.ToBitmap(imageSrcList[imageSelect]);
                BeforeImage.Image?.Dispose();
                BeforeImage.Image = bmp;
                BeforeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (imageSelect < imageSrcList.Count - 1)
            {
                imageSelect++;

                Bitmap bmp = BitmapConverter.ToBitmap(imageSrcList[imageSelect]);
                BeforeImage.Image?.Dispose();
                BeforeImage.Image = bmp;
                BeforeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void GaussianFilter_Func(int sizeX, int sizeY)
        {
            TimeSpan tsStart = new TimeSpan(DateTime.Now.Ticks);

            OpenCvSharp.Size gaussianKernel = new OpenCvSharp.Size(sizeX, sizeY);
            Cv2.GaussianBlur(imageSrcList[imageSelect], filtered, gaussianKernel, 0);

            TimeSpan tsFinish = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan tsGap = tsFinish.Subtract(tsStart);

            textBox_FilterUsageTime.Invoke(new Action(() =>
            {
                textBox_FilterUsageTime.Text = "Filter Processing Time: " + tsGap.TotalMilliseconds + " ms";
            }));
            
        }

        private void GaussianFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SizeX.Text) || string.IsNullOrEmpty(textBox_SizeY.Text))
            {
                MessageBox.Show("홀수의 수를 입력해주세요.", "Gaussian Kernel Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sizeX = int.Parse(textBox_SizeX.Text);
            int sizeY = int.Parse(textBox_SizeY.Text);

            if (sizeX % 2 == 0 || sizeY % 2 == 0)
            {
                MessageBox.Show("홀수의 수를 입력해주세요.", "Gaussian Kernel Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                GaussianFilter_Func(sizeX, sizeY);

                AfterImage.Image?.Dispose();
                AfterImage.Image = BitmapConverter.ToBitmap(filtered);
                AfterImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Cv2.ImWrite("gaussian_" + ofd.SafeFileNames[imageSelect], filtered);
        }

        private void CameraOpen_Click(object sender, EventArgs e)
        {
            isCameraOpen = true;
        }

        private void GrabStart_Click(object sender, EventArgs e)
        {
            if (isCameraOpen == false)
            {
                MessageBox.Show("카메라가 Open되지 않았습니다.", "Camera is not open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageSrcList.Clear();

                foreach (string file in ofd.FileNames)
                {
                    imageSelect = 0;
                    imageSrcList.Add(new Mat(file));
                }

                Bitmap bmp = BitmapConverter.ToBitmap(imageSrcList[0]);
                BeforeImage.Image?.Dispose();
                BeforeImage.Image = bmp;
                BeforeImage.SizeMode = PictureBoxSizeMode.StretchImage;

                if (imageSrcList.Count > 0)
                {
                    isRunning = true;
                    imageGrabThread = new Thread(new ThreadStart(ImageGrabFunc));
                    imageGrabThread.IsBackground = true;
                    imageGrabThread.Start();
                }
            }
        }

        private void ImageGrabFunc()
        {
            while (isRunning)
            {
                var mat = imageSrcList[imageSelect];
                Bitmap bmp = BitmapConverter.ToBitmap(mat);

                // UI 스레드에서 PictureBox에 이미지 설정
                BeforeImage.Invoke(new Action(() =>
                {
                    BeforeImage.Image?.Dispose();
                    BeforeImage.Image = bmp;
                    BeforeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }));

                //after image 플래그 고려해서 추가하기
                if (isFilterEnable == true)
                {
                    if (string.IsNullOrEmpty(textBox_SizeX.Text) || string.IsNullOrEmpty(textBox_SizeY.Text))
                        MessageBox.Show("홀수의 수를 입력해주세요.", "Gaussian Kernel Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        int sizeX = int.Parse(textBox_SizeX.Text);
                        int sizeY = int.Parse(textBox_SizeY.Text);

                        if (sizeX % 2 == 0 || sizeY % 2 == 0)
                        {
                            MessageBox.Show("홀수의 수를 입력해주세요.", "Gaussian Kernel Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            GaussianFilter_Func(sizeX, sizeY);

                            AfterImage.Invoke(new Action(() =>
                            {
                                AfterImage.Image?.Dispose();
                                AfterImage.Image = BitmapConverter.ToBitmap(filtered);
                                AfterImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            }));

                            OpenCvSharp.Cv2.ImWrite("gaussian_" + ofd.SafeFileNames[imageSelect], filtered);
                        }
                    }
                }

                imageSelect = (imageSelect + 1) % imageSrcList.Count;
                Thread.Sleep(1000); // 1초 대기
            }
        }

        private void FilterStart_Click(object sender, EventArgs e)
        {
            isFilterEnable = true;
        }

        private void FilterStop_Click(object sender, EventArgs e)
        {
            isFilterEnable = false;
        }

        private void GrabStop_Click(object sender, EventArgs e)
        {
            isRunning = false;

            if (imageGrabThread != null && imageGrabThread.IsAlive)
            {
                imageGrabThread.Join(); // 안전하게 종료 대기
            }
        }

        private void CameraClose_Click(object sender, EventArgs e)
        {
            isCameraOpen = false;
        }

    }
}
