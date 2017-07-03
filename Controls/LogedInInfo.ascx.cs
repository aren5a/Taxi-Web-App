using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.WebApp.Controls
{
    public partial class LogedInInfo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Common.Data.User user = new Common.Data.User();
                user = HttpContext.Current.Session["CurrentUser"] as Common.Data.User;

                        lblBalance.Text= user.balance.ToString();
                        lblAddress.Text=user.address;
                        lblChargeDate.Text=user.last_charge;
                        lblEmail.Text=user.email;
                        lbllName.Text=user.l_name;
                        lblName.Text=user.name;
                        lblTellNum.Text = user.tell_num;
            }
        }
    }
}