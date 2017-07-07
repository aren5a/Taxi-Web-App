using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.WebApp
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common.Data.User user = new Common.Data.User();
            user = HttpContext.Current.Session[Common.Utility.CurrentUserSession] as Common.Data.User;
            if (user != null)
            {
                if (user.user_type_id != 3) Response.Redirect("LoginForm.aspx");
            }
            else Response.Redirect("LoginForm.aspx");
        }
    }
}