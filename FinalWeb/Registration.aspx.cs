using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Vendor v = new Vendor();
        v.Name = txtName.Text;
        v.CompanyName = "";
        v.CreationTime = DateTime.Now;
        v.DomainID = 0;
        v.EmailId = txtEmail.Text;
        v.Username = txtEmail.Text;
        v.Password = txtPassword.Text;
        v.Photo = "";
        v.MobileNo = txtMobile.Text ;
        v.VendorID = 0;

        VendorLogic vl = new VendorLogic();
        vl.Insert(v);
        Response.Redirect("Login.aspx");

        
    }
}