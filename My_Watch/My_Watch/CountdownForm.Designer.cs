namespace My_Watch
{
    partial class CountdownForm
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
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeLable = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.hourLable = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.hourCB = new System.Windows.Forms.ComboBox();
            this.minutesCB = new System.Windows.Forms.ComboBox();
            this.secondsCB = new System.Windows.Forms.ComboBox();
            this.addSecButton = new System.Windows.Forms.Button();
            this.addMinbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(520, 398);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 58);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(370, 398);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(144, 58);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop ";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(220, 398);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(144, 58);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLable
            // 
            this.timeLable.AutoSize = true;
            this.timeLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.ForeColor = System.Drawing.Color.White;
            this.timeLable.Location = new System.Drawing.Point(226, 54);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(438, 97);
            this.timeLable.TabIndex = 7;
            this.timeLable.Text = "00.00.00";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // hourLable
            // 
            this.hourLable.AutoSize = true;
            this.hourLable.BackColor = System.Drawing.Color.Black;
            this.hourLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLable.ForeColor = System.Drawing.Color.White;
            this.hourLable.Location = new System.Drawing.Point(216, 217);
            this.hourLable.Name = "hourLable";
            this.hourLable.Size = new System.Drawing.Size(83, 24);
            this.hourLable.TabIndex = 13;
            this.hourLable.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.Color.Black;
            this.minutesLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.White;
            this.minutesLabel.Location = new System.Drawing.Point(396, 217);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(105, 24);
            this.minutesLabel.TabIndex = 13;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.BackColor = System.Drawing.Color.Black;
            this.secondLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.ForeColor = System.Drawing.Color.White;
            this.secondLabel.Location = new System.Drawing.Point(578, 217);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(109, 24);
            this.secondLabel.TabIndex = 13;
            this.secondLabel.Text = "Seconds";
            // 
            // hourCB
            // 
            this.hourCB.BackColor = System.Drawing.Color.Black;
            this.hourCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourCB.ForeColor = System.Drawing.Color.White;
            this.hourCB.FormattingEnabled = true;
            this.hourCB.Location = new System.Drawing.Point(220, 264);
            this.hourCB.Name = "hourCB";
            this.hourCB.Size = new System.Drawing.Size(82, 32);
            this.hourCB.TabIndex = 14;
            // 
            // minutesCB
            // 
            this.minutesCB.BackColor = System.Drawing.Color.Black;
            this.minutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesCB.ForeColor = System.Drawing.Color.White;
            this.minutesCB.FormattingEnabled = true;
            this.minutesCB.Location = new System.Drawing.Point(400, 264);
            this.minutesCB.Name = "minutesCB";
            this.minutesCB.Size = new System.Drawing.Size(82, 32);
            this.minutesCB.TabIndex = 14;
            // 
            // secondsCB
            // 
            this.secondsCB.BackColor = System.Drawing.Color.Black;
            this.secondsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondsCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsCB.ForeColor = System.Drawing.Color.White;
            this.secondsCB.FormattingEnabled = true;
            this.secondsCB.Location = new System.Drawing.Point(582, 264);
            this.secondsCB.Name = "secondsCB";
            this.secondsCB.Size = new System.Drawing.Size(82, 32);
            this.secondsCB.TabIndex = 14;
            // 
            // addSecButton
            // 
            this.addSecButton.BackColor = System.Drawing.Color.Black;
            this.addSecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSecButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSecButton.ForeColor = System.Drawing.Color.White;
            this.addSecButton.Location = new System.Drawing.Point(451, 341);
            this.addSecButton.Name = "addSecButton";
            this.addSecButton.Size = new System.Drawing.Size(213, 51);
            this.addSecButton.TabIndex = 15;
            this.addSecButton.Text = "+30sec";
            this.addSecButton.UseVisualStyleBackColor = false;
            this.addSecButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addMinbutton
            // 
            this.addMinbutton.BackColor = System.Drawing.Color.Black;
            this.addMinbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMinbutton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMinbutton.ForeColor = System.Drawing.Color.White;
            this.addMinbutton.Location = new System.Drawing.Point(220, 341);
            this.addMinbutton.Name = "addMinbutton";
            this.addMinbutton.Size = new System.Drawing.Size(213, 51);
            this.addMinbutton.TabIndex = 16;
            this.addMinbutton.Text = "+60sec";
            this.addMinbutton.UseVisualStyleBackColor = false;
            this.addMinbutton.Click += new System.EventHandler(this.addMinbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(306, 461);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 56);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addMinbutton);
            this.Controls.Add(this.addSecButton);
            this.Controls.Add(this.secondsCB);
            this.Controls.Add(this.minutesCB);
            this.Controls.Add(this.hourCB);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hourLable);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "CountdownForm";
            this.Text = "CountdownForm";
            this.Load += new System.EventHandler(this.CountdownForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label hourLable;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.ComboBox hourCB;
        private System.Windows.Forms.ComboBox minutesCB;
        private System.Windows.Forms.ComboBox secondsCB;
        private System.Windows.Forms.Button addSecButton;
        private System.Windows.Forms.Button addMinbutton;
        private System.Windows.Forms.Button exitButton;
    }
}