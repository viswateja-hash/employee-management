using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin.Text = "";
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin.Text == "" && Password.Text == "")
            {
                MessageBox.Show("some information is missing");
            }
            else if (Admin.Text == "Teja" && Password.Text == "1234")
            {
                Home h = new Home();
                h.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("please enter the details");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
