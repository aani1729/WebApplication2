using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; 
using System.Configuration; 

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if user is already authenticated, redirect if necessary
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            con.Open();
            string qry = "SELECT * FROM [demo].[dbo].[demo_users] WHERE username='" + username + "' AND password='" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {   
               
                lblErrorMessage.Text = "Login Success......!!";
                lblErrorMessage.Visible = true;
            }
            else
            {
                lblErrorMessage.Text = "Invalid username or password.";
                lblErrorMessage.Visible = true;
            }
        }
        protected void btnsignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration.aspx");
        }

    }
}