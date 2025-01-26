using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoCWebFormSecurity
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated && !Request.Url.AbsolutePath.ToLower().EndsWith("login.aspx"))
            {
                Response.Redirect("~/Security/Login.aspx");
            }
        }
    }
}