using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_System
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\teja\Documents\Em.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Fetchep()
        {
            try
            {
                con.Open();
                string query = "select *from  emp where Empid='"+textBox1.Text+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["EmpName"].ToString();
                    textBox3.Text = dr["EmpGen"].ToString();
                    textBox4.Text = dr["Emppos"].ToString();
                    textBox5.Text = dr["EmpAdd"].ToString();
                    textBox6.Text = dr["EmpDOB"].ToString();
                    textBox7.Text = dr["EmpPhone"].ToString();


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fetchep();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
