using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class AlarmForm : Form
    {
        int inputHour, inputMinute;
        string alarmHour, alarmMinute, inputTotal;
        int hourClock, minuteClock;

        public AlarmForm()
        {
            InitializeComponent();
        }
   
        private void AlarmForm_Load(object sender, EventArgs e)
        {
            timer.Start();

            for (int i = 0; i < 60; i++)
            {
                this.minutesCB.Items.Add(i.ToString());         
                this.minutesCB.SelectedIndex = 0;
            }
            for (int i = 0; i < 24; i++)
            {
                this.hourCB.Items.Add(i.ToString());
                this.hourCB.SelectedIndex = 0;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hourClock = DateTime.Now.Hour;
            minuteClock = DateTime.Now.Minute;

            hourLabel.Text = hourClock.ToString();
            minuteLabel.Text = minuteClock.ToString();

            RingAlarm();
           
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            alarmHour = hourCB.Text;
            alarmMinute = minutesCB.Text;
            inputHour = Convert.ToInt32(hourCB.Text);
            inputMinute = Convert.ToInt32(minutesCB.Text);      

            if (inputHour < 10)
            {
                alarmHour =  "0" + inputHour;
            }
            else
            {
                alarmHour = inputHour.ToString();
            }

            if (inputMinute < 10)
            {
                alarmMinute = "0" + inputMinute;
            }
            else
            {
                alarmMinute = inputMinute.ToString();
            }

            inputTotal = alarmHour + " : " + alarmMinute;

            alarmlistBox.Items.Add( inputTotal);
            

        }

        void RingAlarm()
        {
            if (alarmHour == hourClock.ToString() && alarmMinute == minuteClock.ToString())
            {
                DialogResult result;
                result = MessageBox.Show("Snooze","Alarm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    


                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
