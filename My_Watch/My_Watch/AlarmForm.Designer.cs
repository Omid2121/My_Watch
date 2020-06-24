namespace My_Watch
{
    partial class AlarmForm
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
            this.minutesCB = new System.Windows.Forms.ComboBox();
            this.hourCB = new System.Windows.Forms.ComboBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.alarmlistBox = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minutesCB
            // 
            this.minutesCB.BackColor = System.Drawing.Color.Black;
            this.minutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesCB.ForeColor = System.Drawing.Color.White;
            this.minutesCB.FormattingEnabled = true;
            this.minutesCB.Location = new System.Drawing.Point(505, 133);
            this.minutesCB.Name = "minutesCB";
            this.minutesCB.Size = new System.Drawing.Size(155, 32);
            this.minutesCB.TabIndex = 15;
            // 
            // hourCB
            // 
            this.hourCB.BackColor = System.Drawing.Color.Black;
            this.hourCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourCB.ForeColor = System.Drawing.Color.White;
            this.hourCB.FormattingEnabled = true;
            this.hourCB.Location = new System.Drawing.Point(273, 133);
            this.hourCB.Name = "hourCB";
            this.hourCB.Size = new System.Drawing.Size(155, 32);
            this.hourCB.TabIndex = 16;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.BackColor = System.Drawing.Color.Black;
            this.mLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel.ForeColor = System.Drawing.Color.White;
            this.mLabel.Location = new System.Drawing.Point(539, 103);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(80, 21);
            this.mLabel.TabIndex = 17;
            this.mLabel.Text = "Minute";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.BackColor = System.Drawing.Color.Black;
            this.hLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLabel.ForeColor = System.Drawing.Color.White;
            this.hLabel.Location = new System.Drawing.Point(311, 105);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(61, 21);
            this.hLabel.TabIndex = 18;
            this.hLabel.Text = "Hour";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Black;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(393, 398);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(144, 54);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Black;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(543, 398);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 54);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.Black;
            this.setButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.ForeColor = System.Drawing.Color.White;
            this.setButton.Location = new System.Drawing.Point(243, 398);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(144, 54);
            this.setButton.TabIndex = 21;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(328, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 54);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // alarmlistBox
            // 
            this.alarmlistBox.BackColor = System.Drawing.Color.Black;
            this.alarmlistBox.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmlistBox.ForeColor = System.Drawing.Color.White;
            this.alarmlistBox.FormattingEnabled = true;
            this.alarmlistBox.ItemHeight = 24;
            this.alarmlistBox.Location = new System.Drawing.Point(243, 183);
            this.alarmlistBox.Name = "alarmlistBox";
            this.alarmlistBox.Size = new System.Drawing.Size(444, 196);
            this.alarmlistBox.TabIndex = 24;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.ForeColor = System.Drawing.Color.White;
            this.hourLabel.Location = new System.Drawing.Point(377, 22);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(84, 58);
            this.hourLabel.TabIndex = 25;
            this.hourLabel.Text = "10";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteLabel.ForeColor = System.Drawing.Color.White;
            this.minuteLabel.Location = new System.Drawing.Point(486, 22);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(84, 58);
            this.minuteLabel.TabIndex = 25;
            this.minuteLabel.Text = "10";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("LIBRARY 3 AM", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(454, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 58);
            this.label.TabIndex = 25;
            this.label.Text = ":";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 539);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.alarmlistBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.minutesCB);
            this.Controls.Add(this.hourCB);
            this.Name = "AlarmForm";
            this.Text = "AlarmForm";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox minutesCB;
        private System.Windows.Forms.ComboBox hourCB;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox alarmlistBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label label;
    }
}