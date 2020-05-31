namespace Elevator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.OutLG = new System.Windows.Forms.PictureBox();
            this.OutLF = new System.Windows.Forms.PictureBox();
            this.OutRF = new System.Windows.Forms.PictureBox();
            this.OutRG = new System.Windows.Forms.PictureBox();
            this.FRequestBtn = new System.Windows.Forms.Button();
            this.GRequestBtn = new System.Windows.Forms.Button();
            this.FirstDisplay = new System.Windows.Forms.TextBox();
            this.GroundDisplay = new System.Windows.Forms.TextBox();
            this.Elevator = new System.Windows.Forms.PictureBox();
            this.InLeft = new System.Windows.Forms.PictureBox();
            this.InRight = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelDisplay = new System.Windows.Forms.TextBox();
            this.GroundFloorBtn = new System.Windows.Forms.Button();
            this.FirstFloorBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OpenDown = new System.Windows.Forms.Timer(this.components);
            this.CloseUp = new System.Windows.Forms.Timer(this.components);
            this.GoUpTimer = new System.Windows.Forms.Timer(this.components);
            this.GoDownTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseDown = new System.Windows.Forms.Timer(this.components);
            this.OpenUp = new System.Windows.Forms.Timer(this.components);
            this.ShowLogs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutLG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InRight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(82, 315);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 552);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(286, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 552);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(81, 535);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(208, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(82, 262);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(206, 14);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // OutLG
            // 
            this.OutLG.Image = ((System.Drawing.Image)(resources.GetObject("OutLG.Image")));
            this.OutLG.Location = new System.Drawing.Point(80, 328);
            this.OutLG.Name = "OutLG";
            this.OutLG.Size = new System.Drawing.Size(106, 211);
            this.OutLG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutLG.TabIndex = 7;
            this.OutLG.TabStop = false;
            // 
            // OutLF
            // 
            this.OutLF.Image = ((System.Drawing.Image)(resources.GetObject("OutLF.Image")));
            this.OutLF.Location = new System.Drawing.Point(80, 52);
            this.OutLF.Name = "OutLF";
            this.OutLF.Size = new System.Drawing.Size(106, 211);
            this.OutLF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutLF.TabIndex = 8;
            this.OutLF.TabStop = false;
            // 
            // OutRF
            // 
            this.OutRF.Image = ((System.Drawing.Image)(resources.GetObject("OutRF.Image")));
            this.OutRF.Location = new System.Drawing.Point(180, 52);
            this.OutRF.Name = "OutRF";
            this.OutRF.Size = new System.Drawing.Size(106, 211);
            this.OutRF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutRF.TabIndex = 9;
            this.OutRF.TabStop = false;
            // 
            // OutRG
            // 
            this.OutRG.Image = ((System.Drawing.Image)(resources.GetObject("OutRG.Image")));
            this.OutRG.Location = new System.Drawing.Point(180, 328);
            this.OutRG.Name = "OutRG";
            this.OutRG.Size = new System.Drawing.Size(106, 211);
            this.OutRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutRG.TabIndex = 10;
            this.OutRG.TabStop = false;
            // 
            // FRequestBtn
            // 
            this.FRequestBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FRequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("FRequestBtn.Image")));
            this.FRequestBtn.Location = new System.Drawing.Point(292, 142);
            this.FRequestBtn.Name = "FRequestBtn";
            this.FRequestBtn.Size = new System.Drawing.Size(56, 69);
            this.FRequestBtn.TabIndex = 11;
            this.FRequestBtn.Text = ".";
            this.FRequestBtn.UseVisualStyleBackColor = false;
            this.FRequestBtn.Click += new System.EventHandler(this.FRequestBtn_Click);
            // 
            // GRequestBtn
            // 
            this.GRequestBtn.BackColor = System.Drawing.Color.White;
            this.GRequestBtn.Image = ((System.Drawing.Image)(resources.GetObject("GRequestBtn.Image")));
            this.GRequestBtn.Location = new System.Drawing.Point(292, 394);
            this.GRequestBtn.Name = "GRequestBtn";
            this.GRequestBtn.Size = new System.Drawing.Size(56, 71);
            this.GRequestBtn.TabIndex = 12;
            this.GRequestBtn.Text = ".";
            this.GRequestBtn.UseVisualStyleBackColor = false;
            this.GRequestBtn.Click += new System.EventHandler(this.GRequestBtn_Click);
            // 
            // FirstDisplay
            // 
            this.FirstDisplay.BackColor = System.Drawing.Color.Black;
            this.FirstDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstDisplay.ForeColor = System.Drawing.Color.Red;
            this.FirstDisplay.Location = new System.Drawing.Point(292, 52);
            this.FirstDisplay.Multiline = true;
            this.FirstDisplay.Name = "FirstDisplay";
            this.FirstDisplay.ReadOnly = true;
            this.FirstDisplay.Size = new System.Drawing.Size(56, 46);
            this.FirstDisplay.TabIndex = 13;
            this.FirstDisplay.Text = "G";
            this.FirstDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroundDisplay
            // 
            this.GroundDisplay.BackColor = System.Drawing.Color.Black;
            this.GroundDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundDisplay.ForeColor = System.Drawing.Color.Red;
            this.GroundDisplay.Location = new System.Drawing.Point(292, 328);
            this.GroundDisplay.Multiline = true;
            this.GroundDisplay.Name = "GroundDisplay";
            this.GroundDisplay.ReadOnly = true;
            this.GroundDisplay.Size = new System.Drawing.Size(55, 47);
            this.GroundDisplay.TabIndex = 14;
            this.GroundDisplay.Text = "G";
            this.GroundDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Elevator
            // 
            this.Elevator.Image = ((System.Drawing.Image)(resources.GetObject("Elevator.Image")));
            this.Elevator.Location = new System.Drawing.Point(82, 328);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(206, 211);
            this.Elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Elevator.TabIndex = 15;
            this.Elevator.TabStop = false;
            // 
            // InLeft
            // 
            this.InLeft.Image = ((System.Drawing.Image)(resources.GetObject("InLeft.Image")));
            this.InLeft.Location = new System.Drawing.Point(80, 328);
            this.InLeft.MaximumSize = new System.Drawing.Size(106, 211);
            this.InLeft.Name = "InLeft";
            this.InLeft.Size = new System.Drawing.Size(106, 211);
            this.InLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InLeft.TabIndex = 16;
            this.InLeft.TabStop = false;
            // 
            // InRight
            // 
            this.InRight.Image = ((System.Drawing.Image)(resources.GetObject("InRight.Image")));
            this.InRight.Location = new System.Drawing.Point(180, 328);
            this.InRight.Name = "InRight";
            this.InRight.Size = new System.Drawing.Size(106, 211);
            this.InRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InRight.TabIndex = 17;
            this.InRight.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.PanelDisplay);
            this.groupBox1.Controls.Add(this.GroundFloorBtn);
            this.groupBox1.Controls.Add(this.FirstFloorBtn);
            this.groupBox1.Location = new System.Drawing.Point(380, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 385);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.BackColor = System.Drawing.Color.Black;
            this.PanelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelDisplay.ForeColor = System.Drawing.Color.Red;
            this.PanelDisplay.Location = new System.Drawing.Point(27, 30);
            this.PanelDisplay.Multiline = true;
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.ReadOnly = true;
            this.PanelDisplay.Size = new System.Drawing.Size(85, 96);
            this.PanelDisplay.TabIndex = 21;
            this.PanelDisplay.Text = "G";
            this.PanelDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroundFloorBtn
            // 
            this.GroundFloorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroundFloorBtn.Location = new System.Drawing.Point(38, 249);
            this.GroundFloorBtn.Name = "GroundFloorBtn";
            this.GroundFloorBtn.Size = new System.Drawing.Size(64, 77);
            this.GroundFloorBtn.TabIndex = 20;
            this.GroundFloorBtn.Text = "G";
            this.GroundFloorBtn.UseVisualStyleBackColor = true;
            this.GroundFloorBtn.Click += new System.EventHandler(this.GroundFloorBtn_Click);
            // 
            // FirstFloorBtn
            // 
            this.FirstFloorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstFloorBtn.Location = new System.Drawing.Point(38, 148);
            this.FirstFloorBtn.Name = "FirstFloorBtn";
            this.FirstFloorBtn.Size = new System.Drawing.Size(64, 74);
            this.FirstFloorBtn.TabIndex = 19;
            this.FirstFloorBtn.Text = "1";
            this.FirstFloorBtn.UseVisualStyleBackColor = true;
            this.FirstFloorBtn.Click += new System.EventHandler(this.FirstFloorBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(537, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(654, 384);
            this.listBox1.TabIndex = 19;
            // 
            // OpenDown
            // 
            this.OpenDown.Tick += new System.EventHandler(this.OpenDown_Tick);
            // 
            // CloseUp
            // 
            this.CloseUp.Tick += new System.EventHandler(this.CloseUp_Tick);
            // 
            // GoUpTimer
            // 
            this.GoUpTimer.Tick += new System.EventHandler(this.GoUpTimer_Tick);
            // 
            // GoDownTimer
            // 
            this.GoDownTimer.Tick += new System.EventHandler(this.GoDownTimer_Tick);
            // 
            // CloseDown
            // 
            this.CloseDown.Tick += new System.EventHandler(this.CloseDown_Tick);
            // 
            // OpenUp
            // 
            this.OpenUp.Tick += new System.EventHandler(this.OpenUp_Tick);
            // 
            // ShowLogs
            // 
            this.ShowLogs.Location = new System.Drawing.Point(537, 427);
            this.ShowLogs.Name = "ShowLogs";
            this.ShowLogs.Size = new System.Drawing.Size(134, 38);
            this.ShowLogs.TabIndex = 20;
            this.ShowLogs.Text = "Show DataLogs";
            this.ShowLogs.UseVisualStyleBackColor = true;
            this.ShowLogs.Click += new System.EventHandler(this.ShowLogs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1057, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(694, 427);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(347, 38);
            this.progressBar2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 590);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowLogs);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroundDisplay);
            this.Controls.Add(this.FirstDisplay);
            this.Controls.Add(this.GRequestBtn);
            this.Controls.Add(this.FRequestBtn);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.OutLF);
            this.Controls.Add(this.OutRF);
            this.Controls.Add(this.OutLG);
            this.Controls.Add(this.OutRG);
            this.Controls.Add(this.InRight);
            this.Controls.Add(this.InLeft);
            this.Controls.Add(this.Elevator);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutLG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InRight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox OutLG;
        private System.Windows.Forms.PictureBox OutLF;
        private System.Windows.Forms.PictureBox OutRF;
        private System.Windows.Forms.PictureBox OutRG;
        private System.Windows.Forms.Button FRequestBtn;
        private System.Windows.Forms.Button GRequestBtn;
        private System.Windows.Forms.TextBox FirstDisplay;
        private System.Windows.Forms.TextBox GroundDisplay;
        private System.Windows.Forms.PictureBox Elevator;
        private System.Windows.Forms.PictureBox InLeft;
        private System.Windows.Forms.PictureBox InRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GroundFloorBtn;
        private System.Windows.Forms.Button FirstFloorBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer OpenDown;
        private System.Windows.Forms.Timer CloseUp;
        private System.Windows.Forms.Timer GoUpTimer;
        private System.Windows.Forms.Timer GoDownTimer;
        private System.Windows.Forms.TextBox PanelDisplay;
        private System.Windows.Forms.Timer CloseDown;
        private System.Windows.Forms.Timer OpenUp;
        private System.Windows.Forms.Button ShowLogs;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

