using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class AddOfficer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Officer ao = new Officer();

        ao.AllocationTime = DateTime.Now;
        ao.EmailId = txtEmailID.Text;
        ao.MobileNo = txtMobile.Text;
        ao.Name = txtName.Text;
        ao.Password = txtPassword.Text;
        ao.ProjectID = 0;
        ao.Username = txtUsername.Text;

        OfficerLogic ol = new OfficerLogic();
        ol.Insert(ao);
        
        Response.Redirect("ManageOfficer.aspx");


    }
}