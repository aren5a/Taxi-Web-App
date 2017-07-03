using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Taxi.WebApp.Controls
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //...
        }

        protected void bttLogin_Click(object sender, EventArgs e)
        {
            Taxi.Common.Data.User user = new Taxi.Common.Data.User();
            
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = " شناسه کاربری و رمز عبور را وارد نمایید";
                txtUsername.BorderColor = System.Drawing.Color.Red;
                txtPassword.BorderColor = System.Drawing.Color.Red;
            }

            else
            {

                try
                {
                    
                    IList<Common.Data.User> list = new List<Common.Data.User>();
                    ArrayList field=new ArrayList();
                    ArrayList value =new ArrayList();
                    field.Add( "username");
                    value.Add( txtUsername.Text);
                    field.Add( "password");
                    value.Add( txtPassword.Text);
                    list = new Taxi.BLL.UserBLL().GetUserbyFilter(field,value);
                    user = list[0];

                    HttpContext.Current.Session.Add(Common.Utility.CurrentUserSession, user);


                    if (list[0].user_type_id == 3)
                    {
                        Response.Redirect("LogedInUserInfo(Pass).aspx");
                    }
                    else if (list[0].user_type_id == 2)
                    {
                        Response.Redirect("LogedInUserInfo(Oper).aspx");
                    }
                    
                    if (list[0].user_type_id == 1)
                    {
                        Response.Redirect("LogedInUserInfo(Admin).aspx");                      
                    }
                    lblError.Text = " شناسه کاربری یا رمز عبور درست نمی باشد";
                }
                catch(Exception ex) 
                {
                    Common.GeneralException ex1 = new Common.GeneralException(Common.TaxiResource.Login_Err, ex);
                    lblError.Text = ex1.Message;
                }

            }
        }
    }
}