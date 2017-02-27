using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTimeCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
        private void monthCalendar1_Click(object sender, System.EventArgs e)
        {
            Trnsfer("FindTimeCSharp.Form2");
        }

        private void newTasksToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
