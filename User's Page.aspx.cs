using System;
using System.Web.UI;

public partial class User_s_Page : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser"] != null)
        {
            Welcomelabel.Text = "Welcome: "+ Session["CurrentUser"];
        }
        else
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CurrentUser"] = null;
        Response.Redirect("LoginPage.aspx");
    }
}