using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic;
using DataAccess;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {


        if (txtUsername.Text == "a" && txtPassword.Text == "a")
        {
            Session["user"] = "admin";
            
            Response.Redirect("Home.aspx");
            return;

        }

       SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\SONY\Desktop\Practice1\FinalWeb\App_Data\Database.mdf;Integrated Security=True;User Instance=True");

        string query = "select * from Vendor where Username=@Username AND Password=@Password";

        SqlCommand comm = new SqlCommand(query, conn);
        comm.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
        comm.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));

        SqlDataAdapter adapter = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        conn.Open();
        adapter.Fill(dt);
        conn.Close();

        if (dt.Rows.Count > 0)
        {
            Session["VendorID"] = Convert.ToInt32(dt.Rows[0]["VendorID"]);
            
            Response.Redirect("VendorHome.aspx");
            return;
        }


        
        query = "select * from Officer where Username=@Username AND Password=@Password";

        comm = new SqlCommand(query, conn);
        comm.Parameters.Add(new SqlParameter("@Username", txtUsername.Text));
        comm.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));

        adapter = new SqlDataAdapter(comm);
        dt = new DataTable();
        conn.Open();
        adapter.Fill(dt);
        conn.Close();

         if (dt.Rows.Count > 0)
        {
            Session["OfficerID"] = Convert.ToInt32(dt.Rows[0]["OfficerID"]);
            Response.Redirect("OfficerDetail.aspx");
            return;
        }







    
       
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");

    }
}