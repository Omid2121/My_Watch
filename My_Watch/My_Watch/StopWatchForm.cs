using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class StopWatchForm : Form
    {
        MyStopWatch myStopwatch = new MyStopWatch();

        public StopWatchForm()
        {
            InitializeComponent();
            lapButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            myStopwatch.stopwatch.Start();
            lapButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            myStopwatch.stopwatch.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            myStopwatch.stopwatch.Reset();
            lapsListBox.Items.Clear();
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            DrawTime();
        }

        private void DrawTime()
        {
            centiSLable.Text = String.Format("{0:00}", myStopwatch.stopwatch.Elapsed.Milliseconds);
            secoundsLable.Text = String.Format("{0:00}", myStopwatch.stopwatch.Elapsed.Seconds);
            minutesLable.Text = String.Format("{0:00}", myStopwatch.stopwatch.Elapsed.Minutes);
            hoursLable.Text = String.Format("{0:00}", myStopwatch.stopwatch.Elapsed.Hours);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }

        private void lapButton_Click(object sender, EventArgs e)
        {
            lapsListBox.Items.Add(myStopwatch.CreateLap());
        }
    }
}
