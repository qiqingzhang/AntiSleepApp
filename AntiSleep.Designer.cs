namespace AntiSleepApp
{
    partial class AntiSleep
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Pin2Desktop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(97, 40);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(97, 103);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(123, 48);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(118, 175);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 12);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "never stop...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Pin2Desktop
            // 
            this.Pin2Desktop.AutoSize = true;
            this.Pin2Desktop.Location = new System.Drawing.Point(12, 8);
            this.Pin2Desktop.Name = "Pin2Desktop";
            this.Pin2Desktop.Size = new System.Drawing.Size(108, 16);
            this.Pin2Desktop.TabIndex = 4;
            this.Pin2Desktop.Text = "Pin to desktop";
            this.Pin2Desktop.UseVisualStyleBackColor = true;
            this.Pin2Desktop.CheckedChanged += new System.EventHandler(this.Pin2Desktop_CheckedChanged);
            // 
            // AntiSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 255);
            this.Controls.Add(this.Pin2Desktop);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AntiSleep";
            this.Text = "AntiSleep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox Pin2Desktop;
    }
}

