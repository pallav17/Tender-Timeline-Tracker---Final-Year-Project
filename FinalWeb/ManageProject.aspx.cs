using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using System.Data;
public partial class ManageProject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProjectLogic pl = new ProjectLogic();
        DataTable dt = pl.SelectAll();

        Repeater1.DataSource = dt;
        Repeater1.DataBind();

    }
}