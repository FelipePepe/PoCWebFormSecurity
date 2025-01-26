using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoCWebFormSecurity.Security
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (IsValidUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lblMessage.Text = "Usuario o contraseña incorrectos.";
            }

        }

        private bool IsValidUser(string username, string password)
        {
            // Simulación de autenticación; se recomienda consultar una base de datos
            return username == "admin" && password == "1234";
        }
    }
}