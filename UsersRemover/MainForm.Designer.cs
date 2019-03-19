namespace UsersRemover
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPath = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblSelectedPath = new System.Windows.Forms.Label();
            this.StopProgramTimer = new System.Windows.Forms.Timer(this.components);
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.bntTimerStop = new System.Windows.Forms.Button();
            this.TimerProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(161, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "S&elect folder path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(179, 12);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(83, 23);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "&Go";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 38);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path:";
            // 
            // lblSelectedPath
            // 
            this.lblSelectedPath.AutoSize = true;
            this.lblSelectedPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelectedPath.Location = new System.Drawing.Point(50, 38);
            this.lblSelectedPath.Name = "lblSelectedPath";
            this.lblSelectedPath.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPath.TabIndex = 3;
            // 
            // startTimer
            // 
            this.startTimer.Interval = 5000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // bntTimerStop
            // 
            this.bntTimerStop.Location = new System.Drawing.Point(268, 12);
            this.bntTimerStop.Name = "bntTimerStop";
            this.bntTimerStop.Size = new System.Drawing.Size(83, 23);
            this.bntTimerStop.TabIndex = 4;
            this.bntTimerStop.Text = "S&top ";
            this.bntTimerStop.UseVisualStyleBackColor = true;
            this.bntTimerStop.Click += new System.EventHandler(this.bntTimerStop_Click);
            // 
            // TimerProgress
            // 
            this.TimerProgress.Location = new System.Drawing.Point(15, 54);
            this.TimerProgress.Name = "TimerProgress";
            this.TimerProgress.Size = new System.Drawing.Size(335, 19);
            this.TimerProgress.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 85);
            this.Controls.Add(this.TimerProgress);
            this.Controls.Add(this.bntTimerStop);
            this.Controls.Add(this.lblSelectedPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.btnPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Users Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblSelectedPath;
        private System.Windows.Forms.Timer StopProgramTimer;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Button bntTimerStop;
        private System.Windows.Forms.ProgressBar TimerProgress;
    }
}

