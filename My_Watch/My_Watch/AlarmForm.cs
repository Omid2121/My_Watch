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
        public AlarmForm()
        {
            InitializeComponent();
        }
   
        private void AlarmForm_Load(object sender, EventArgs e)
        {
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
    }
}
