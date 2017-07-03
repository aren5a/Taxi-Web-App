using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taxi.WebApp.Controls
{
    public partial class News_Insert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InfoLBL.Visible = false;
        }

        protected void Sub_NewsBtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NewsTXT.Text.Trim()) || string.IsNullOrEmpty(SubjectTXT.Text.Trim())) { throw new Common.GeneralException(Common.TaxiResource.News_Insert); };
                Common.Data.News news = new Common.Data.News();
                news.news_Sub = SubjectTXT.Text;
                news.news_full = NewsTXT.Text;
                new BLL.NewsBLL().Submit_News(news);
            }
            catch(Exception ex)
            {
                InfoLBL.Visible=true;
                InfoLBL.Text = ex.Message;
            }
        }
    }
}