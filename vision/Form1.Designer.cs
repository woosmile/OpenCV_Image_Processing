namespace vision
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenImage = new System.Windows.Forms.Button();
            this.BeforeImage = new System.Windows.Forms.PictureBox();
            this.AfterImage = new System.Windows.Forms.PictureBox();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.GaussianFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SizeX = new System.Windows.Forms.TextBox();
            this.textBox_SizeY = new System.Windows.Forms.TextBox();
            this.SaveImage = new System.Windows.Forms.Button();
            this.textBox_FilterUsageTime = new System.Windows.Forms.TextBox();
            this.CameraOpen = new System.Windows.Forms.Button();
            this.GrabStart = new System.Windows.Forms.Button();
            this.FilterStart = new System.Windows.Forms.Button();
            this.FilterStop = new System.Windows.Forms.Button();
            this.GrabStop = new System.Windows.Forms.Button();
            this.CameraClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BeforeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(31, 35);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(153, 51);
            this.OpenImage.TabIndex = 0;
            this.OpenImage.Text = "Open Image";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // BeforeImage
            // 
            this.BeforeImage.Location = new System.Drawing.Point(217, 35);
            this.BeforeImage.Name = "BeforeImage";
            this.BeforeImage.Size = new System.Drawing.Size(720, 720);
            this.BeforeImage.TabIndex = 1;
            this.BeforeImage.TabStop = false;
            // 
            // AfterImage
            // 
            this.AfterImage.Location = new System.Drawing.Point(966, 35);
            this.AfterImage.Name = "AfterImage";
            this.AfterImage.Size = new System.Drawing.Size(720, 720);
            this.AfterImage.TabIndex = 2;
            this.AfterImage.TabStop = false;
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(31, 306);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(71, 33);
            this.Prev.TabIndex = 3;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(113, 306);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(71, 33);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // GaussianFilter
            // 
            this.GaussianFilter.Location = new System.Drawing.Point(31, 206);
            this.GaussianFilter.Name = "GaussianFilter";
            this.GaussianFilter.Size = new System.Drawing.Size(153, 44);
            this.GaussianFilter.TabIndex = 5;
            this.GaussianFilter.Text = "Gaussian Filter";
            this.GaussianFilter.UseVisualStyleBackColor = true;
            this.GaussianFilter.Click += new System.EventHandler(this.GaussianFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "size X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gaussian Kernel Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "size Y";
            // 
            // textBox_SizeX
            // 
            this.textBox_SizeX.Location = new System.Drawing.Point(102, 128);
            this.textBox_SizeX.Name = "textBox_SizeX";
            this.textBox_SizeX.Size = new System.Drawing.Size(61, 21);
            this.textBox_SizeX.TabIndex = 11;
            // 
            // textBox_SizeY
            // 
            this.textBox_SizeY.Location = new System.Drawing.Point(102, 170);
            this.textBox_SizeY.Name = "textBox_SizeY";
            this.textBox_SizeY.Size = new System.Drawing.Size(61, 21);
            this.textBox_SizeY.TabIndex = 12;
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(31, 256);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(153, 44);
            this.SaveImage.TabIndex = 13;
            this.SaveImage.Text = "Save Image";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // textBox_FilterUsageTime
            // 
            this.textBox_FilterUsageTime.Location = new System.Drawing.Point(966, 775);
            this.textBox_FilterUsageTime.Name = "textBox_FilterUsageTime";
            this.textBox_FilterUsageTime.ReadOnly = true;
            this.textBox_FilterUsageTime.Size = new System.Drawing.Size(225, 21);
            this.textBox_FilterUsageTime.TabIndex = 14;
            this.textBox_FilterUsageTime.Text = "\r\n";
            // 
            // CameraOpen
            // 
            this.CameraOpen.Location = new System.Drawing.Point(31, 427);
            this.CameraOpen.Name = "CameraOpen";
            this.CameraOpen.Size = new System.Drawing.Size(153, 40);
            this.CameraOpen.TabIndex = 15;
            this.CameraOpen.Text = "Camera Open";
            this.CameraOpen.UseVisualStyleBackColor = true;
            this.CameraOpen.Click += new System.EventHandler(this.CameraOpen_Click);
            // 
            // GrabStart
            // 
            this.GrabStart.Location = new System.Drawing.Point(31, 484);
            this.GrabStart.Name = "GrabStart";
            this.GrabStart.Size = new System.Drawing.Size(153, 40);
            this.GrabStart.TabIndex = 16;
            this.GrabStart.Text = "Grab Start";
            this.GrabStart.UseVisualStyleBackColor = true;
            this.GrabStart.Click += new System.EventHandler(this.GrabStart_Click);
            // 
            // FilterStart
            // 
            this.FilterStart.Location = new System.Drawing.Point(31, 543);
            this.FilterStart.Name = "FilterStart";
            this.FilterStart.Size = new System.Drawing.Size(153, 40);
            this.FilterStart.TabIndex = 17;
            this.FilterStart.Text = "Filter Start";
            this.FilterStart.UseVisualStyleBackColor = true;
            this.FilterStart.Click += new System.EventHandler(this.FilterStart_Click);
            // 
            // FilterStop
            // 
            this.FilterStop.Location = new System.Drawing.Point(31, 599);
            this.FilterStop.Name = "FilterStop";
            this.FilterStop.Size = new System.Drawing.Size(153, 40);
            this.FilterStop.TabIndex = 18;
            this.FilterStop.Text = "Filter Stop";
            this.FilterStop.UseVisualStyleBackColor = true;
            this.FilterStop.Click += new System.EventHandler(this.FilterStop_Click);
            // 
            // GrabStop
            // 
            this.GrabStop.Location = new System.Drawing.Point(31, 656);
            this.GrabStop.Name = "GrabStop";
            this.GrabStop.Size = new System.Drawing.Size(153, 40);
            this.GrabStop.TabIndex = 19;
            this.GrabStop.Text = "Grab Stop";
            this.GrabStop.UseVisualStyleBackColor = true;
            this.GrabStop.Click += new System.EventHandler(this.GrabStop_Click);
            // 
            // CameraClose
            // 
            this.CameraClose.Location = new System.Drawing.Point(31, 715);
            this.CameraClose.Name = "CameraClose";
            this.CameraClose.Size = new System.Drawing.Size(153, 40);
            this.CameraClose.TabIndex = 20;
            this.CameraClose.Text = "Camera Close";
            this.CameraClose.UseVisualStyleBackColor = true;
            this.CameraClose.Click += new System.EventHandler(this.CameraClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sequence";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1714, 821);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraClose);
            this.Controls.Add(this.GrabStop);
            this.Controls.Add(this.FilterStop);
            this.Controls.Add(this.FilterStart);
            this.Controls.Add(this.GrabStart);
            this.Controls.Add(this.CameraOpen);
            this.Controls.Add(this.textBox_FilterUsageTime);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.textBox_SizeY);
            this.Controls.Add(this.textBox_SizeX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GaussianFilter);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.AfterImage);
            this.Controls.Add(this.BeforeImage);
            this.Controls.Add(this.OpenImage);
            this.Name = "Form1";
            this.Text = "Vision Program Prototype";
            ((System.ComponentModel.ISupportInitialize)(this.BeforeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.PictureBox BeforeImage;
        private System.Windows.Forms.PictureBox AfterImage;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button GaussianFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SizeX;
        private System.Windows.Forms.TextBox textBox_SizeY;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.TextBox textBox_FilterUsageTime;
        private System.Windows.Forms.Button CameraOpen;
        private System.Windows.Forms.Button GrabStart;
        private System.Windows.Forms.Button FilterStart;
        private System.Windows.Forms.Button FilterStop;
        private System.Windows.Forms.Button GrabStop;
        private System.Windows.Forms.Button CameraClose;
        private System.Windows.Forms.Label label4;
    }
}

