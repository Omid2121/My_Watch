using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class WatchForm : Form
    {
        public WatchForm()
        {
            InitializeComponent();
        }

        private void WatchForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hourLable.Text = DateTime.Now.ToString("HH:mm");
            secondLable.Text = DateTime.Now.ToString("ss");
            dateLable.Text = DateTime.Now.ToString("dd MMM yyy");
            dayLable.Text = DateTime.Now.ToString("dddd");
            secondLable.Location = new Point(hourLable.Location.X + hourLable.Width, secondLable.Location.Y);
        }

        private void secondLable_Click(object sender, EventArgs e)
        {

        }
    }
}
