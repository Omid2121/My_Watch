﻿using System;
using System.Windows.Forms;

namespace My_Watch
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            WatchForm openForm = new WatchForm();
            openForm.Show();
            Visible = false;
        }

        private void stopWatchButton_Click(object sender, EventArgs e)
        {
            StopWatchForm openForm = new StopWatchForm();
            openForm.Show();
            Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;   
                Application.Exit();
            
        }
    }
}