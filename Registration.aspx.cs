using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;


public partial class Registration : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) return;
        if(Check_User())Response.Write("User already exists!");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(!Page.IsValid)return;
        try
        {
            if (!IsPostBack||Check_User()) return;
            var conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            const string adduser = "INSERT INTO [Table] (Username, Email, Password, Country) values (@Uname, @UEMail, @UPass, @UCountry)";
            var comm = new SqlCommand(adduser, conn);
            comm.Parameters.AddWithValue("@UName", UserName.Text);
            comm.Parameters.AddWithValue("@UEMail", EMail.Text);
            comm.Parameters.AddWithValue("@UPass", Password.Text);
            comm.Parameters.AddWithValue("@UCountry", Country.Text);
            comm.ExecuteNonQuery();
            Response.Redirect("LoginPage.aspx");
            Response.Write("Registration has been successful.");
            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error Occured :"+ex);
        }
    }

    protected bool Check_User()
    {
        var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
        conn.Open();
        var checkuser = "SELECT count(*) FROM [Table] WHERE Username = '" + UserName.Text + "'";
        var comm = new SqlCommand(checkuser, conn);
        var temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        if (temp == 1)
        {
            return true;
        }
        conn.Close();
        return false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
}