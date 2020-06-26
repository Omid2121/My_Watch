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
        string notte;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (alarmlistBox.SelectedIndex >= 0)
            {
                alarmlistBox.Items.RemoveAt(alarmlistBox.SelectedIndex);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (alarmlistBox.SelectedIndex > -1)
            {
                alarmlistBox.Items[alarmlistBox.SelectedIndex] = string.Format("{0:00} : {1:00} {2:00}", 
                    Convert.ToInt32(hourCB.Text), 
                    Convert.ToInt32(minutesCB.Text), 
                    Convert.ToString(noteTextBox.Text));
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
                alarmHour = "0" + inputHour;

            else
                alarmHour = inputHour.ToString();

            if (inputMinute < 10)
                alarmMinute = "0" + inputMinute;

            else
                alarmMinute = inputMinute.ToString();


            if (noteTextBox.Text != "")
            {
                notte = noteTextBox.Text;
                noteTextBox.Clear();
            }

            inputTotal = alarmHour + " : " + alarmMinute + " " + notte;
            alarmlistBox.Items.Add(inputTotal);

            hourCB.SelectedIndex = 0;
            minutesCB.SelectedIndex = 0;
        }

        bool alarmOn = true;
        void RingAlarm()
        {

            if (alarmHour != null && alarmMinute != null)
            {
                string tempHour;
                string tempMinute;

                if (alarmHour[0] == '0')
                    tempHour = alarmHour.Substring(1, 1);
                else
                    tempHour = alarmHour;


                if (alarmMinute[0] == '0')
                    tempMinute = alarmMinute.Substring(1, 1);
                else
                    tempMinute = alarmMinute;


                if (tempHour == hourClock.ToString() && tempMinute == minuteClock.ToString())
                {
                    if (alarmOn)
                    {
                        alarmOn = false;
                        DialogResult result;
                        result = MessageBox.Show("Snooze", "Alarm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            alarmMinute = (Convert.ToInt32(alarmMinute) + 5).ToString();
                        }
                        else
                        {
                            
                        }
                        alarmOn = true;
                    }
                }
            }
        }

    }
}
