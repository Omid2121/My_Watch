using System;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class StopWatchForm : Form
    {
        StopWatch stopwatch = new StopWatch();

        public StopWatchForm()
        {
            InitializeComponent();
        }

        private void StopWatchForm_Load(object sender, EventArgs e)
        {
            ResetTime();
            stopwatch.isActive = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatch.isActive = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatch.isActive = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopwatch.isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            stopwatch.centiSeconds = 0;
            stopwatch.seconds = 0;
            stopwatch.minutes = 0;
            stopwatch.hours = 0;
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.isActive)
            {
                stopwatch.centiSeconds++;

                if (stopwatch.centiSeconds >= 100)
                {
                    stopwatch.seconds++;
                    stopwatch.centiSeconds = 0;

                    if (stopwatch.seconds >= 60)
                    {
                        stopwatch.minutes++;
                        stopwatch.seconds = 0;

                        if (stopwatch.minutes >= 60)
                        {
                            stopwatch.hours++;
                            stopwatch.minutes = 0;
                        }
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            centiSLable.Text = String.Format("{0:00}", stopwatch.centiSeconds);
            secoundsLable.Text = String.Format("{0:00}", stopwatch.seconds);
            minutesLable.Text = String.Format("{0:00}", stopwatch.minutes);
            hoursLable.Text = String.Format("{0:00}", stopwatch.hours);
        }


    }
}
