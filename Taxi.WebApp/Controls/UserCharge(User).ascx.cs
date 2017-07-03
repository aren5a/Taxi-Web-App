using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.WebApp.Controls
{
    public partial class UserCharge_User_ : System.Web.UI.UserControl
    {
        static Common.Data.User user = new Common.Data.User();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                user = HttpContext.Current.Session["CurrentUser"] as Common.Data.User;
                //Visible Labels and Enable charge 
                Enable_Charge();

                //Put value in labels 

                LBLUsername2.Text = user.username;
                LBLUserCharge2.Text = user.balance.ToString();
            }

        }
        protected void Enable_Charge()
        {
            lblChargeErr.Text = "";
            LBLUserCharge.Visible = true;
            LBLUsername.Visible = true;
            LBLUserCharge2.Visible = true;
            LBLUsername2.Visible = true;
            TXTChargeAmount.Enabled = true;
            bttCharge.Enabled = true;
        }

        protected void bttCharge_Click(object sender, EventArgs e)
        {
            try
            {
                new BLL.UserBLL().charge_user(user, int.Parse(TXTChargeAmount.Text));
                LBLUserCharge2.Text = user.balance.ToString();
                TXTChargeAmount.Text = "";
            }
            catch (Exception ex)
            {
                lblChargeErr.Text = ex.Message;
            }
        }
    }
}