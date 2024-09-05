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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            Display();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\teja\Documents\Em.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Display()
        {
            try
            {
                con.Open();
                String Query = "select *from emp";
                SqlDataAdapter da = new SqlDataAdapter(Query,con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text == "" || textBox4.Text=="")
                {
                    MessageBox.Show("information is missing");

                }
                else
                {
                    con.Open();
                    string query = "insert into emp values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.SelectedItem.ToString() +"','"+dateTimePicker1.Value.Date+"','"+textBox4.Text+"','"+ comboBox1.SelectedItem.ToString()+"')";
                    SqlCommand cmd =new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted successfully");
                    Display();

                }
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
        private void Employee_Load(object sender,EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string query = "UPDATE emp SET EmpName= @Empname,EmpAdd=@EmpAdd,Emppos=@EmpPOs,EmpDob=@EmpDob,EmpPhone =@EmpPhone,EmpGen=@EmpGen where Empid=@Empid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmpName",textBox2.Text);
                cmd.Parameters.AddWithValue("@EmpAdd", textBox3.Text);
                cmd.Parameters.AddWithValue("@EmpPos", comboBox2.Text);
                cmd.Parameters.AddWithValue("@EmpDob", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@EmpPhone", textBox4.Text);
                cmd.Parameters.AddWithValue("@EmpGen", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Empid", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated successfully");
                Display();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter the emp id");

                }
                else
                {
                    con.Open();
                    string query = "delete from emp where Empid = '"+textBox1.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted successfully");
                    Display();

                }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
           // textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

