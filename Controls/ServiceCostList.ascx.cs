using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace Taxi.WebApp.Controls
{
    public partial class ServiceCostList : System.Web.UI.UserControl
    {
        static DataSet ds = new DataSet();
        static string filter = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCost.Visible = false;
                txtCost.Visible = false;
                bttSubCost.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string text = TXTSearch.Text;
            if (!string.IsNullOrEmpty(TXTSearch.Text))
            {
                filter = string.Format("{0} like '%{1}%'", Common.Data.Service.name_Field, text);
                filter += string.Format(" or {0} like '%{1}%'", Common.Data.Service.l_name_Field, text);
                filter += string.Format(" or {0} like '%{1}%'", "D_Name", text);
            }
            string fromDate="";
            string toDate="";
            if (!string.IsNullOrEmpty(FromListYear.SelectedValue) && !string.IsNullOrEmpty(FromListMounth.SelectedValue) && !string.IsNullOrEmpty(FromListDay.SelectedValue)) 
            fromDate = FromListYear.SelectedValue + "/" + FromListMounth.SelectedValue + "/" + FromListDay.SelectedValue;
            if (!string.IsNullOrEmpty(ToListYear.SelectedValue) && !string.IsNullOrEmpty(ToListMounth.SelectedValue) && !string.IsNullOrEmpty(ToListDay.SelectedValue)) 
            toDate = ToListYear.SelectedValue + "/" + ToListMounth.SelectedValue + "/" + ToListDay.SelectedValue;
            if (!string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(toDate))
                {
                    if (!string.IsNullOrEmpty(TXTSearch.Text))
                    {
                        filter += string.Format("and  {0}>='{1}' "
                            , Common.Data.Service.date_Field
                            , fromDate);
                    }
                    else
                    {
                        filter += string.Format("{0}>='{1}' "
                            , Common.Data.Service.date_Field
                            , fromDate);
                    }
                }
            }
            if (!string.IsNullOrEmpty(toDate) & string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(toDate))
                {
                    if (!string.IsNullOrEmpty(TXTSearch.Text))
                    {
                        filter += string.Format("and {0}<='{1}' "
                        , Common.Data.Service.date_Field
                        , toDate);
                    }
                    else
                    {
                        filter += string.Format("{0}<='{1}' "
                        , Common.Data.Service.date_Field
                        , toDate);
                    }
                }
            }
            if (!string.IsNullOrEmpty(toDate) & !string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(toDate))
                {
                filter += string.Format(" and  {0}<='{1}' "
                    , Common.Data.Service.date_Field
                    , toDate);
                }
                
            }
            
            string orderby=Common.Data.Service.date_Field +" DESC, "+Common.Data.Service.time_Field+" DESC";
            ds = new BLL.ServiceBLL().GetbyFilter(filter, orderby);
            gvService.DataSource = ds;
            gvService.DataBind();
        }
        public bool Validate_Date(string date)
        {
           if(!Regex.IsMatch(date,@"^((((19|20)(([02468][048])|([13579][26]))-02-29))|((20[0-9][0-9])|(19[0-9][0-9]))-((((0[1-9])|(1[0-2]))-((0[1-9])|(1\d)|(2[0-8])))|((((0[13578])|(1[02]))-31)|(((0[1,3-9])|(1[0-2]))-(29|30)))))$"))
           {
               lblErr.Visible=false;
               return true;
           }
           else lblErr.Text="تاریخ را مانند مثال وارد نمایید";
           return false;
        }


        protected void bttSubCost_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtCost.Text,@"^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"))
            {
                bool result;
               
                if (HFUserID.Value.Trim() != "" )  // User is Registered
                {
                    result = new BLL.ServiceBLL().Update_User_Cost(int.Parse(HFUserID.Value), decimal.Parse(txtCost.Text));
                    if (!result) lblCostErr.Text = "اعتبار کاربر به اندازه کافی نمی باشد";
                    else { txtCost.Text = ""; txtCost.Visible = false; lblCost.Visible = false; bttSubCost.Visible = false; lblCostErr.Visible = false; }
                    
                }
                else  // User is not Registered
                {
                    new BLL.ServiceBLL().Update_Cost(int.Parse(HFServiceID.Value), decimal.Parse(txtCost.Text));
                    txtCost.Visible = false; lblCost.Visible = false; bttSubCost.Visible = false;
                }
            }
        }

        protected void Cmd_Pay(object sender, EventArgs e)
        {
            //Gets the Clicked Row's Index
            int rowIndex = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;

            HFServiceID.Value = gvService.DataKeys[rowIndex]["Service_Id"].ToString();
            HFUserID.Value = gvService.DataKeys[rowIndex]["UserId"].ToString();

            txtCost.Visible = true; lblCost.Visible = true; bttSubCost.Visible = true;
        }
        protected Boolean IsNotPaid(Decimal cost)
        {
            if (cost > 0) return false;
            else return true;
        }

        protected void gvService_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvService.PageIndex = e.NewPageIndex;
            string orderby = Common.Data.Service.date_Field + " DESC, " + Common.Data.Service.time_Field + " DESC";
            ds = new BLL.ServiceBLL().GetbyFilter(filter, orderby);
            gvService.DataSource = ds;
            gvService.DataBind();
        }

    }
}