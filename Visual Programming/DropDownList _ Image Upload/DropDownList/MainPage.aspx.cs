using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=Qureshi-PC;Initial Catalog=employee_crud;Integrated Security=True ");
                con.Open();
                string qry = "Select * from employees";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ddl.DataTextField = "fname";
                    ddl.DataValueField = "id";
                    ddl.DataSource = dt;
                    ddl.DataBind();
                }
                con.Close();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = ddl.SelectedItem.Value.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (fup.HasFile)
            {
                string filename = Path.GetFileName(fup.FileName);
                fup.PostedFile.SaveAs(Server.MapPath("~/images/" + filename));
                SqlConnection con = new SqlConnection(@"Data Source=Qureshi-PC;Initial Catalog=ImageUpload;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Images (imageName,imagePath) values (@name,@path)", con);
                cmd.Parameters.AddWithValue("@name", filename);
                cmd.Parameters.AddWithValue("@path", "images/" + filename);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            

        }
    }
}