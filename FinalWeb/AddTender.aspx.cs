using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class AddTender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
        protected void btnLogin_Click(object sender, EventArgs e)
    {
        Tender td = new Tender();
        td.CreationTime = DateTime.Now;
        td.Details = txtDetails.Text;
        td.Documents = "";
        td.EstimatedTime = DateTime.Now;
        td.ProposedCost = 0;
        td.ProjectID = 0;
        td.Status = txtStatus.Text;
        td.TenderID = 0;
        td.VendorID = 0;
        td.Manpower = 0;

        TenderLogic t1 = new TenderLogic();
        t1.Insert(td);

        Response.Redirect("VendorHome.aspx");

    }
}