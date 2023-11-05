namespace Pose_Detection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabPage = new MetroFramework.Controls.MetroTabControl();
            this.TabPage_detector = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ConnectCam = new System.Windows.Forms.Button();
            this.ComboBox_device = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_W = new System.Windows.Forms.RadioButton();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_H = new System.Windows.Forms.RadioButton();
            this.button_shoot = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.pictureBox_cam = new System.Windows.Forms.PictureBox();
            this.TabPage_mypose = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_pose = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.TabPage_detector.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam)).BeginInit();
            this.TabPage_mypose.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TabPage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.93416F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.TabPage_detector);
            this.TabPage.Controls.Add(this.TabPage_mypose);
            this.TabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage.Location = new System.Drawing.Point(4, 4);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(673, 577);
            this.TabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabPage.TabIndex = 0;
            this.TabPage.UseSelectable = true;
            // 
            // TabPage_detector
            // 
            this.TabPage_detector.Controls.Add(this.tableLayoutPanel2);
            this.TabPage_detector.HorizontalScrollbarBarColor = true;
            this.TabPage_detector.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_detector.HorizontalScrollbarSize = 10;
            this.TabPage_detector.Location = new System.Drawing.Point(4, 38);
            this.TabPage_detector.Margin = new System.Windows.Forms.Padding(0);
            this.TabPage_detector.Name = "TabPage_detector";
            this.TabPage_detector.Size = new System.Drawing.Size(665, 535);
            this.TabPage_detector.TabIndex = 0;
            this.TabPage_detector.Text = "Detector";
            this.TabPage_detector.VerticalScrollbarBarColor = true;
            this.TabPage_detector.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_detector.VerticalScrollbarSize = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 519);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox_cam, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(642, 517);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.415094F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25954F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71756F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel6.Controls.Add(this.button_ConnectCam, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ComboBox_device, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_shoot, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_Pause, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_start, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(642, 37);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // button_ConnectCam
            // 
            this.button_ConnectCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ConnectCam.Location = new System.Drawing.Point(108, 3);
            this.button_ConnectCam.Name = "button_ConnectCam";
            this.button_ConnectCam.Size = new System.Drawing.Size(83, 31);
            this.button_ConnectCam.TabIndex = 9;
            this.button_ConnectCam.Text = "Connect";
            this.button_ConnectCam.UseVisualStyleBackColor = true;
            this.button_ConnectCam.Click += new System.EventHandler(this.button_ConnectCam_Click);
            // 
            // ComboBox_device
            // 
            this.ComboBox_device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_device.FormattingEnabled = true;
            this.ComboBox_device.ItemHeight = 24;
            this.ComboBox_device.Location = new System.Drawing.Point(3, 3);
            this.ComboBox_device.Name = "ComboBox_device";
            this.ComboBox_device.Size = new System.Drawing.Size(99, 30);
            this.ComboBox_device.TabIndex = 1;
            this.ComboBox_device.UseSelectable = true;
            this.ComboBox_device.SelectedIndexChanged += new System.EventHandler(this.SelectCam);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Controls.Add(this.radioButton_W, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButton_M, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButton_H, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(451, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 37);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // radioButton_W
            // 
            this.radioButton_W.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_W.AutoSize = true;
            this.radioButton_W.Location = new System.Drawing.Point(138, 8);
            this.radioButton_W.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_W.Name = "radioButton_W";
            this.radioButton_W.Size = new System.Drawing.Size(43, 20);
            this.radioButton_W.TabIndex = 3;
            this.radioButton_W.TabStop = true;
            this.radioButton_W.Text = "W";
            this.radioButton_W.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_W.UseVisualStyleBackColor = true;
            this.radioButton_W.CheckedChanged += new System.EventHandler(this.RadioCheckChange);
            // 
            // radioButton_M
            // 
            this.radioButton_M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_M.AutoSize = true;
            this.radioButton_M.Location = new System.Drawing.Point(95, 8);
            this.radioButton_M.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.Size = new System.Drawing.Size(43, 20);
            this.radioButton_M.TabIndex = 2;
            this.radioButton_M.TabStop = true;
            this.radioButton_M.Text = "M";
            this.radioButton_M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_M.UseVisualStyleBackColor = true;
            this.radioButton_M.CheckedChanged += new System.EventHandler(this.RadioCheckChange);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode";
            // 
            // radioButton_H
            // 
            this.radioButton_H.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_H.AutoSize = true;
            this.radioButton_H.Location = new System.Drawing.Point(52, 8);
            this.radioButton_H.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_H.Name = "radioButton_H";
            this.radioButton_H.Size = new System.Drawing.Size(43, 20);
            this.radioButton_H.TabIndex = 1;
            this.radioButton_H.TabStop = true;
            this.radioButton_H.Text = "H";
            this.radioButton_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_H.UseVisualStyleBackColor = true;
            this.radioButton_H.CheckedChanged += new System.EventHandler(this.RadioCheckChange);
            // 
            // button_shoot
            // 
            this.button_shoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_shoot.Location = new System.Drawing.Point(197, 3);
            this.button_shoot.Name = "button_shoot";
            this.button_shoot.Size = new System.Drawing.Size(73, 31);
            this.button_shoot.TabIndex = 11;
            this.button_shoot.Text = "Shoot";
            this.button_shoot.UseVisualStyleBackColor = true;
            this.button_shoot.Click += new System.EventHandler(this.button_shoot_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Pause.Location = new System.Drawing.Point(385, 3);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(63, 31);
            this.button_Pause.TabIndex = 6;
            this.button_Pause.Text = "Pause";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Location = new System.Drawing.Point(292, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(87, 31);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // pictureBox_cam
            // 
            this.pictureBox_cam.Location = new System.Drawing.Point(0, 37);
            this.pictureBox_cam.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_cam.Name = "pictureBox_cam";
            this.pictureBox_cam.Size = new System.Drawing.Size(640, 480);
            this.pictureBox_cam.TabIndex = 4;
            this.pictureBox_cam.TabStop = false;
            // 
            // TabPage_mypose
            // 
            this.TabPage_mypose.Controls.Add(this.tableLayoutPanel4);
            this.TabPage_mypose.HorizontalScrollbarBarColor = true;
            this.TabPage_mypose.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_mypose.HorizontalScrollbarSize = 10;
            this.TabPage_mypose.Location = new System.Drawing.Point(4, 38);
            this.TabPage_mypose.Name = "TabPage_mypose";
            this.TabPage_mypose.Size = new System.Drawing.Size(665, 535);
            this.TabPage_mypose.TabIndex = 1;
            this.TabPage_mypose.Text = "My Pose";
            this.TabPage_mypose.VerticalScrollbarBarColor = true;
            this.TabPage_mypose.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_mypose.VerticalScrollbarSize = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.listView_pose, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(28, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(616, 490);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // listView_pose
            // 
            this.listView_pose.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView_pose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_pose.GridLines = true;
            this.listView_pose.HideSelection = false;
            this.listView_pose.Location = new System.Drawing.Point(3, 3);
            this.listView_pose.Name = "listView_pose";
            this.listView_pose.Size = new System.Drawing.Size(610, 484);
            this.listView_pose.TabIndex = 3;
            this.listView_pose.UseCompatibleStateImageBehavior = false;
            this.listView_pose.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Posture";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sholder_slope";
            this.columnHeader3.Width = 288;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Neck_distance_rate";
            this.columnHeader5.Width = 157;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 666);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(22, 60, 22, 21);
            this.Text = "Good Posture Detector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage_detector.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam)).EndInit();
            this.TabPage_mypose.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl TabPage;
        private MetroFramework.Controls.MetroTabPage TabPage_detector;
        private MetroFramework.Controls.MetroTabPage TabPage_mypose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_cam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_ConnectCam;
        private MetroFramework.Controls.MetroComboBox ComboBox_device;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_W;
        private System.Windows.Forms.RadioButton radioButton_M;
        private System.Windows.Forms.RadioButton radioButton_H;
        private System.Windows.Forms.Button button_shoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView listView_pose;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

