using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class AddProject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Project ap = new Project();

        ap.Budget = txtBudget.Text;
        ap.CreationTime = DateTime.Now;
        ap.Details = txtDetails.Text;
        ap.Documents = "";
        ap.DomainID = Convert.ToInt32(ddlDomain.SelectedItem.Value);

        ap.Name = txtName.Text;
        ap.OfficerID = 0;
        ap.Status = "CREATED";

        DateTime dt1;
        if (!DateTime.TryParseExact(txtTenderDeadline.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dt1))
        {
            return;
        }



        DateTime dt2;
        if (!DateTime.TryParseExact(txtScheduledStart.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dt2))
        {
            return;
        }



        DateTime dt3;
        if (!DateTime.TryParseExact(txtScheduledEnding.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dt3))
        {
            return;
        }

        ap.TenderDeadline = dt1;
        ap.ScheduledStartTime = dt2;
        ap.ScheduledEndTime = dt3;
        ap.CreationTime = DateTime.Now;
        ap.StartTime = DateTime.Now;
        ap.EndTime = DateTime.Now;

        ProjectLogic pl = new ProjectLogic();
        pl.Insert(ap);

        Response.Redirect("ManageProject.aspx");
    }
}