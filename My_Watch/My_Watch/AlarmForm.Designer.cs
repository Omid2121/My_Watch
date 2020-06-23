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
            this.minutesCB = new System.Windows.Forms.ComboBox();
            this.hourCB = new System.Windows.Forms.ComboBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hourLable = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minutesCB
            // 
            this.minutesCB.BackColor = System.Drawing.Color.Black;
            this.minutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesCB.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesCB.ForeColor = System.Drawing.Color.White;
            this.minutesCB.FormattingEnabled = true;
            this.minutesCB.Location = new System.Drawing.Point(512, 98);
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
            this.hourCB.Location = new System.Drawing.Point(277, 98);
            this.hourCB.Name = "hourCB";
            this.hourCB.Size = new System.Drawing.Size(155, 32);
            this.hourCB.TabIndex = 16;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.Color.Black;
            this.minutesLabel.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.White;
            this.minutesLabel.Location = new System.Drawing.Point(508, 30);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(92, 24);
            this.minutesLabel.TabIndex = 17;
            this.minutesLabel.Text = "Minute";
            // 
            // hourLable
            // 
            this.hourLable.AutoSize = true;
            this.hourLable.BackColor = System.Drawing.Color.Black;
            this.hourLable.Font = new System.Drawing.Font("LIBRARY 3 AM", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLable.ForeColor = System.Drawing.Color.White;
            this.hourLable.Location = new System.Drawing.Point(273, 30);
            this.hourLable.Name = "hourLable";
            this.hourLable.Size = new System.Drawing.Size(70, 24);
            this.hourLable.TabIndex = 18;
            this.hourLable.Text = "Hour";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Black;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(393, 420);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(144, 74);
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
            this.deleteButton.Location = new System.Drawing.Point(543, 420);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 74);
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
            this.setButton.Location = new System.Drawing.Point(243, 420);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(144, 74);
            this.setButton.TabIndex = 21;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("LIBRARY 3 AM", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(214, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 263);
            this.textBox1.TabIndex = 22;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 539);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hourLable);
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
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hourLable;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}