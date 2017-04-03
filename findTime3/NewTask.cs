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
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }
        DatabaseConnection objConnection;
        string conString;
        DataSet ds;
        DataRow dRow;
        int MaxRows;
        int inc = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNewTask.Clear();
            txtStartTime.Clear();
            txtEndTime.Clear();
            NavigateRecords();

            DataRow row = ds.Tables[0].NewRow();
            row[1] = txtNewTask.Text;


        }
        
        private void freeTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FreeTime().Show();
            this.Hide();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewTask().Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = txtNewTask.Text;
            ds.Tables[0].Rows.Add(row);
            row[1] = txtNewTask.Text;
            row[2] = txtStartTime.Text;
            row[3] = txtEndTime.Text;
            row[4] = txtDescription.Text;

            ds.Tables[0].Rows.Add(row);

        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            try
            {
                objConnection = new DatabaseConnection();
                conString = Properties.Settings.Default.NewTask;
                objConnection.connection_string = conString;
                ds = objConnection.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;
                NavigateRecords();


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtNewTask.Text = dRow.ItemArray.GetValue(1).ToString();
            txtStartTime.Text = dRow.ItemArray.GetValue(2).ToString();
            txtEndTime.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDescription.Text = dRow.ItemArray.GetValue(4).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows -1 )
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No More Records");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Task");
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }


