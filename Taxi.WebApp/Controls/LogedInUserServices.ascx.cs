using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Taxi.WebApp.Controls
{
    public partial class LogedInUserServices : System.Web.UI.UserControl
    {
        static string orderby;
        static string filter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Common.Data.User user = new Common.Data.User();
                user = HttpContext.Current.Session["CurrentUser"] as Common.Data.User;

                orderby = Common.Data.Service.date_Field + " DESC";
                filter = " Userid =" + user.UserID.ToString() + " ";
                DataSet ds = new BLL.ServiceBLL().GetbyFilter(filter, orderby);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            DataSet ds = new BLL.ServiceBLL().GetbyFilter(filter, orderby);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}