namespace My_Watch
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.watchButton = new System.Windows.Forms.Button();
            this.stopWatchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alarmButton = new System.Windows.Forms.Button();
            this.countDownButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // watchButton
            // 
            this.watchButton.BackColor = System.Drawing.Color.Black;
            this.watchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.ForeColor = System.Drawing.Color.White;
            this.watchButton.Location = new System.Drawing.Point(276, 320);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(209, 59);
            this.watchButton.TabIndex = 0;
            this.watchButton.Text = "Clock";
            this.watchButton.UseVisualStyleBackColor = false;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // stopWatchButton
            // 
            this.stopWatchButton.BackColor = System.Drawing.Color.Black;
            this.stopWatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopWatchButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatchButton.ForeColor = System.Drawing.Color.White;
            this.stopWatchButton.Location = new System.Drawing.Point(276, 390);
            this.stopWatchButton.Name = "stopWatchButton";
            this.stopWatchButton.Size = new System.Drawing.Size(209, 59);
            this.stopWatchButton.TabIndex = 0;
            this.stopWatchButton.Text = "Stopwatch";
            this.stopWatchButton.UseVisualStyleBackColor = false;
            this.stopWatchButton.Click += new System.EventHandler(this.stopWatchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(351, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 66);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // alarmButton
            // 
            this.alarmButton.BackColor = System.Drawing.Color.Black;
            this.alarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarmButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmButton.ForeColor = System.Drawing.Color.White;
            this.alarmButton.Location = new System.Drawing.Point(491, 320);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(209, 59);
            this.alarmButton.TabIndex = 0;
            this.alarmButton.Text = "Alarm";
            this.alarmButton.UseVisualStyleBackColor = false;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // countDownButton
            // 
            this.countDownButton.BackColor = System.Drawing.Color.Black;
            this.countDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countDownButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownButton.ForeColor = System.Drawing.Color.White;
            this.countDownButton.Location = new System.Drawing.Point(491, 390);
            this.countDownButton.Name = "countDownButton";
            this.countDownButton.Size = new System.Drawing.Size(209, 59);
            this.countDownButton.TabIndex = 0;
            this.countDownButton.Text = "Countdown";
            this.countDownButton.UseVisualStyleBackColor = false;
            this.countDownButton.Click += new System.EventHandler(this.countDownButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(971, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countDownButton);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.stopWatchButton);
            this.Controls.Add(this.watchButton);
            this.Name = "Menu";
            this.Text = "Watch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Button stopWatchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Button countDownButton;
    }
}

