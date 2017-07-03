using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.WebApp.Controls
{
    public partial class LogOut : System.Web.UI.UserControl
    {
        static Common.Data.User currentUser = new Common.Data.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            currentUser = Session["CurrentUser"] as Common.Data.User;
            if (currentUser != null)
            {
                
               
                lblUserName.Text = currentUser.username + " خوش آمدید ";
                btnLogOut.Text = "خروج";
            }
            else
            {
                lblUserName.Text = "";
                btnLogOut.Text = "ورود";
            }
        }
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            currentUser = Session["CurrentUser"] as Common.Data.User;
            if (currentUser != null)
            {
                Session.Abandon();
                btnLogOut.Text = "ورود";
                lblUserName.Visible = false;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}