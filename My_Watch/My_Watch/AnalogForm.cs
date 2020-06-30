using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class AnalogForm : Form
    {
        int hour, minute;

        Dictionary<int, string> dict = new Dictionary<int, string>()
        {
                {60, "LX"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
        };

        public AnalogForm()
        {
            InitializeComponent();
        }

        private void AnalogForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Menu openForm = new Menu();
            openForm.Show();
            Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = string.Format("{0} : {1}", toNumeral(hour), toNumeral(minute));
        }

        private string toNumeral(int i)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int key in dict.Keys)
            {
                while (key <= i)
                {
                    sb.Append(dict[key]);
                    i -= key;
                }
            }

            return sb.ToString();
        }
    }
}
