namespace My_Watch
{
    partial class StopWatchForm
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
            this.centiSLable = new System.Windows.Forms.Label();
            this.minutesLable = new System.Windows.Forms.Label();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.secoundsLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(542, 367);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 74);
            this.resetButton.TabIndex = 1;
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
            this.stopButton.Location = new System.Drawing.Point(392, 367);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(144, 74);
            this.stopButton.TabIndex = 2;
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
            this.startButton.Location = new System.Drawing.Point(242, 367);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(144, 74);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // centiSLable
            // 
            this.centiSLable.AutoSize = true;
            this.centiSLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centiSLable.ForeColor = System.Drawing.Color.White;
            this.centiSLable.Location = new System.Drawing.Point(707, 97);
            this.centiSLable.Name = "centiSLable";
            this.centiSLable.Size = new System.Drawing.Size(95, 58);
            this.centiSLable.TabIndex = 5;
            this.centiSLable.Text = "00";
            // 
            // minutesLable
            // 
            this.minutesLable.AutoSize = true;
            this.minutesLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLable.ForeColor = System.Drawing.Color.White;
            this.minutesLable.Location = new System.Drawing.Point(338, 64);
            this.minutesLable.Name = "minutesLable";
            this.minutesLable.Size = new System.Drawing.Size(160, 97);
            this.minutesLable.TabIndex = 6;
            this.minutesLable.Text = "00";
            // 
            // stopWatchTimer
            // 
            this.stopWatchTimer.Enabled = true;
            this.stopWatchTimer.Interval = 10;
            this.stopWatchTimer.Tick += new System.EventHandler(this.stopWatchTimer_Tick);
            // 
            // secoundsLable
            // 
            this.secoundsLable.AutoSize = true;
            this.secoundsLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secoundsLable.ForeColor = System.Drawing.Color.White;
            this.secoundsLable.Location = new System.Drawing.Point(525, 64);
            this.secoundsLable.Name = "secoundsLable";
            this.secoundsLable.Size = new System.Drawing.Size(160, 97);
            this.secoundsLable.TabIndex = 6;
            this.secoundsLable.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 97);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LIBRARY 3 AM", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(682, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 97);
            this.label3.TabIndex = 6;
            this.label3.Text = "00";
            // 
            // hoursLable
            // 
            this.hoursLable.AutoSize = true;
            this.hoursLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLable.ForeColor = System.Drawing.Color.White;
            this.hoursLable.Location = new System.Drawing.Point(145, 64);
            this.hoursLable.Name = "hoursLable";
            this.hoursLable.Size = new System.Drawing.Size(160, 97);
            this.hoursLable.TabIndex = 6;
            this.hoursLable.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LIBRARY 3 AM", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(291, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 97);
            this.label5.TabIndex = 6;
            this.label5.Text = ".";
            // 
            // StopWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(927, 527);
            this.Controls.Add(this.centiSLable);
            this.Controls.Add(this.secoundsLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minutesLable);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "StopWatchForm";
            this.Text = "StopWatchForm";
            this.Load += new System.EventHandler(this.StopWatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label centiSLable;
        private System.Windows.Forms.Label minutesLable;
        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.Label secoundsLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hoursLable;
        private System.Windows.Forms.Label label5;
    }
}