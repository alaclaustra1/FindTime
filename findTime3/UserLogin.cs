﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findTime3
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewTask().Show();
            this.Hide();
        }

        private void freeTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FreeTime().Show();
            this.Hide();
        }
    }
}
