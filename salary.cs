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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_management_System
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\teja\Documents\Em.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Fetchep()
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("enter emp id");
                }
                con.Open();
                string query = "select *from  emp where Empid='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["EmpName"].ToString();
                    //  textBox3.Text = dr["EmpGen"].ToString();
                    textBox3.Text = dr["Emppos"].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }*/
        int Dailybase,total;

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fetchep();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="")
            {
                MessageBox.Show("select an employee");
            }
            else if(textBox4.Text==""  || Convert.ToInt32(textBox4.Text)>30)
            {
                MessageBox.Show("Enter a valid no of days");
            }
            else
            {
                if (textBox3.Text == "Manager")
                {
                    Dailybase = 1200;
                }
                else if (textBox3.Text == "Senior developer") 
                {
                    Dailybase = 1000;
                }
                else if (textBox3.Text == "junior developer") 
                {
                    Dailybase = 900;
                }
                else if (textBox3.Text == "Accountant") 
                {
                    Dailybase = 800;
                }
                else  
                {
                    Dailybase = 700;
                }
                total = Dailybase * Convert.ToInt32(textBox4.Text);
                richTextBox1.Text = "Employee id :" + textBox1.Text+ "\n" + "Employee Name:" + textBox2.Text + "\n" +"Employee Position :"+ textBox3.Text+"\n"+"Daily salaray:"+Dailybase+"\n"+"Working days"+ textBox4.Text+"\n"+ "Total salaray:"+total+"\n";
            }
        }

    }
}