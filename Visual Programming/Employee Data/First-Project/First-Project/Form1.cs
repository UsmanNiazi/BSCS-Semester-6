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
         
            string idt = id.Text;
            string query = "Select * from employees where  id ='" + idt + "'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=employee_crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(dt.Rows[0]["fname"].ToString()+" is Found");
                 fname.Text= dt.Rows[0]["fname"].ToString(); 
                 lname.Text= dt.Rows[0]["lname"].ToString(); 
                 gender.Text= dt.Rows[0]["gender"].ToString(); 
                age.Text= dt.Rows[0]["age"].ToString(); 
                dob.Text= dt.Rows[0]["dob"].ToString(); 
                cell.Text= dt.Rows[0]["cell"].ToString(); 
                nation.Text= dt.Rows[0]["nation"].ToString(); 
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
            string fnamet = fname.Text;
            string lnamet = lname.Text;
            string gendert = gender.Text;
            string aget =    age.Text;
            string dobt = dob.Text;
            string cellt = cell.Text;
            string nationt = nation.Text;
            string idt = id.Text;
            string query = "Insert into employees (fname,lname,gender,age,dob,cell,nation) values('" + fnamet + "','" + lnamet + "','" + gendert + "','" + aget + "','" + dobt + "','" + cellt + "','" + nationt + "')";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=employee_crud;Integrated Security=True";
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
            string fnamet = fname.Text;
            string lnamet = lname.Text;
            string gendert = gender.Text;
            string aget = age.Text;
            string dobt = dob.Text;
            string cellt = cell.Text;
            string nationt = nation.Text;
            string idt = id.Text;
            string query = "update employees set  fname = '" + fnamet + "' , lname = '" + lnamet + "' , gender = '" + gendert + "' , age = '" + aget + "' , dob = '" + dobt + "' , cell = '" + cellt + "' , nation = '" + nationt + "' where id= '" + idt+"'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=employee_crud;Integrated Security=True";
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
            string idt = id.Text;
            string query = "delete employees where id= '" + idt + "'";
            string con = @"Data Source=Qureshi-PC;Initial Catalog=employee_crud;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);



            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Alert!!! ID no  "+idt+" deleted Successfully");
            }
            else
            {
                MessageBox.Show("Alert!!! ID no  " + idt + "not found !!! deletion Failed");
            }
            sqlCon.Close();
        }
    }
}
