using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;


public partial class LoginPage : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registration.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            var finduser = "SELECT count(*) FROM [Table] WHERE Username = '" + lUserName.Text + "' AND Password = '" +
                           lPassword.Text + "'";
            var comm = new SqlCommand(finduser, conn);
            var temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                Session["CurrentUser"] = lUserName.Text;
                Response.Redirect("User's Page.aspx");
            }
            else
            {
                Response.Write("Bad credentials");
            }
        }
        catch (Exception ex)
        {
            Response.Write("Error Occured: " + ex);
        }
    }
}