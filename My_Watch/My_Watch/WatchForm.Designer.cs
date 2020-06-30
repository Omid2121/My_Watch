namespace My_Watch
{
    partial class WatchForm
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
            this.dayLable = new System.Windows.Forms.Label();
            this.secondLable = new System.Windows.Forms.Label();
            this.dateLable = new System.Windows.Forms.Label();
            this.hourLable = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayLable
            // 
            this.dayLable.AutoSize = true;
            this.dayLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLable.ForeColor = System.Drawing.Color.White;
            this.dayLable.Location = new System.Drawing.Point(568, 271);
            this.dayLable.Name = "dayLable";
            this.dayLable.Size = new System.Drawing.Size(170, 40);
            this.dayLable.TabIndex = 1;
            this.dayLable.Text = "Monday";
            // 
            // secondLable
            // 
            this.secondLable.AutoSize = true;
            this.secondLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLable.ForeColor = System.Drawing.Color.White;
            this.secondLable.Location = new System.Drawing.Point(681, 119);
            this.secondLable.Name = "secondLable";
            this.secondLable.Size = new System.Drawing.Size(106, 73);
            this.secondLable.TabIndex = 2;
            this.secondLable.Text = "10";
            // 
            // dateLable
            // 
            this.dateLable.AutoSize = true;
            this.dateLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLable.ForeColor = System.Drawing.Color.White;
            this.dateLable.Location = new System.Drawing.Point(192, 271);
            this.dateLable.Name = "dateLable";
            this.dateLable.Size = new System.Drawing.Size(262, 40);
            this.dateLable.TabIndex = 3;
            this.dateLable.Text = "22 june 2020";
            // 
            // hourLable
            // 
            this.hourLable.AutoSize = true;
            this.hourLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 79.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLable.ForeColor = System.Drawing.Color.White;
            this.hourLable.Location = new System.Drawing.Point(241, 30);
            this.hourLable.Name = "hourLable";
            this.hourLable.Size = new System.Drawing.Size(434, 162);
            this.hourLable.TabIndex = 4;
            this.hourLable.Text = "10.10";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(325, 478);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 56);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // WatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(969, 557);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dayLable);
            this.Controls.Add(this.secondLable);
            this.Controls.Add(this.dateLable);
            this.Controls.Add(this.hourLable);
            this.Name = "WatchForm";
            this.Text = "Watch";
            this.Load += new System.EventHandler(this.WatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayLable;
        private System.Windows.Forms.Label secondLable;
        private System.Windows.Forms.Label dateLable;
        private System.Windows.Forms.Label hourLable;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button exitButton;
    }
}