using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            SqlCommand com = new SqlCommand("strlogin", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", txtUsername.Text);
            SqlParameter p3 = new SqlParameter("password", txtPassword.Text);
            SqlParameter p2 = new SqlParameter("email", txtEmail.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p3);
            com.Parameters.Add(p2);
            con.Open();
            SqlDataReader rd = com.ExecuteReader();
            lblErrorMessage.Text = "Registered Sucessfully";
            lblErrorMessage.Visible = true;

        }
        private bool IsValidRegistrationData(string username, string email, string password)
        {
            // Implement your own validation logic (e.g., check for empty fields, validate email format)
            // This is just a placeholder example
            return !string.IsNullOrWhiteSpace(username) &&
                   !string.IsNullOrWhiteSpace(email) &&
                   !string.IsNullOrWhiteSpace(password);
        }

        private void SaveUserRegistration(string username, string email, string password)
        {
            // Implement your own logic to save user registration data (e.g., store in database)
            // This is just a placeholder example
            // You should hash the password before saving it to the database for security
        }

    }
}