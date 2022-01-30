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

namespace First_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = t1.Text;
            string email = t2.Text;
            string id = t3.Text;
            string query = "Select * from users where  id ='" + id + "'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=crud_operations;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(dt.Rows[0]["name"].ToString()+" is Found");
                t1.Text=dt.Rows[0]["name"].ToString();
                t2.Text=dt.Rows[0]["email"].ToString();
                t3.Text=dt.Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("Result not Fount / Error 404");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        { 
            string name = t1.Text;
            string email = t2.Text;
            string query = "Insert into users (name,email) values('" + name + "','" + email + "')";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=crud_operations;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            if (cmd.ExecuteNonQuery() > 0) {
                MessageBox.Show("Alert!!! Signed Up Successfully");
            }
            else
            {
                MessageBox.Show("Alert!!! Signed Up Failed");
            }
            sqlCon.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = t1.Text;
            string email = t2.Text;
            string id = t3.Text;
            string query = "update users set name= '"+name+ "' , email = '" + email + "' where id= '" + id+"'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=crud_operations;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
   


            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Alert!!! Update Successfully");
            }
            else
            {
                MessageBox.Show("Alert!!! Update Failed");
            }
            sqlCon.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = t3.Text;
            string query = "delete users where id= '" + id + "'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=crud_operations;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);



            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Alert!!! ID no  "+id+" deleted Successfully");
            }
            else
            {
                MessageBox.Show("Alert!!! ID no  " + id + "not found !!! deletion Failed");
            }
            sqlCon.Close();
        }
    }
}
