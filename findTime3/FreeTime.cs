using System;
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
    public partial class FreeTime : Form
    {
        public FreeTime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
            this.Hide();
        }
    }
}
