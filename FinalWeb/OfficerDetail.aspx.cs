using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class OfficerDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Officer o = new Officer();
        o.Name = txtName.Text;
        o.MobileNo = txtMobile.Text;
        o.EmailId = txtEmailID.Text;
        o.Password = "";
        o.ProjectID = 0;
        o.Username = "";
        o.AllocationTime = DateTime.Now;


        OfficerLogic ol = new OfficerLogic();
        ol.Insert(o);

        Response.Redirect("OfficerDetail.aspx");
      
    }
}