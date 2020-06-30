using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class CountdownForm : Form
    {
        TimeSpan ts;
        int hours, minutes, seconds;

        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                if(seconds <= 0)
                {
                    seconds = 0;
                }
                if (seconds >= 59)
                {
                    seconds = 59;
                }
            }
        }

        public CountdownForm()
        {
            InitializeComponent();
        }

        private void CountdownForm_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 60; i++)
            {
                this.minutesCB.Items.Add(i.ToString());
                this.secondsCB.Items.Add(i.ToString());
                this.minutesCB.SelectedIndex = 0;
                this.secondsCB.SelectedIndex = 0;

            }
            for (int i = 0; i < 24; i++)
            {
                this.hourCB.Items.Add(i.ToString());
                this.hourCB.SelectedIndex = 0;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (timeLable.Text == "00.00.00")
            {
                hours = Convert.ToInt32(hourCB.Text);
                minutes = Convert.ToInt32(minutesCB.Text);
                Seconds = Convert.ToInt32(secondsCB.Text);
                ts = new TimeSpan(hours, minutes, Seconds);
            }

            if (ts.Hours == 0 && ts.Minutes == 0 && ts.Seconds == 0)
            {
            }
            else
            {
                countdownTimer.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(0, 0, 0);
            hourCB.SelectedIndex = 0;
            minutesCB.SelectedIndex = 0;
            secondsCB.SelectedIndex = 0;
            countdownTimer.Stop();
            timeLable.Text = "00.00.00";

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            ts -= new TimeSpan(0, 0, 1);
            
            timeLable.Text = string.Format("{0:00}.{1:00}.{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);

            if (ts.Hours ==0 && ts.Minutes == 0 && ts.Seconds==0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Time's up!");         
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ts += new TimeSpan(0, 0, 30);
        }

        private void addMinbutton_Click(object sender, EventArgs e)
        {
            ts += new TimeSpan(0, 1, 0);
        }
    }
}
