using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;

namespace Taxi.WebApp.Controls
{
    public partial class UserList_by_Filter_ : System.Web.UI.UserControl
    {
        static string filterdate = "";
        static string filterQuantity;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttSearch_Click(object sender, EventArgs e)
        {
            string fromDate = "";
            string toDate = "";
            if (!string.IsNullOrEmpty(FromListYear.SelectedValue) && !string.IsNullOrEmpty(FromListMounth.SelectedValue) && !string.IsNullOrEmpty(FromListDay.SelectedValue))
                fromDate = FromListYear.SelectedValue + "/" + FromListMounth.SelectedValue + "/" + FromListDay.SelectedValue;
            if (!string.IsNullOrEmpty(ToListYear.SelectedValue) && !string.IsNullOrEmpty(ToListMounth.SelectedValue) && !string.IsNullOrEmpty(ToListDay.SelectedValue))
                toDate = ToListYear.SelectedValue + "/" + ToListMounth.SelectedValue + "/" + ToListDay.SelectedValue;

            if (!string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(fromDate))
                {

                        filterdate = string.Format(" {0}>='{1}' "
                            , Common.Data.Service.date_Field
                            , fromDate);
                  
                }
            }
            if (!string.IsNullOrEmpty(toDate) & string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(toDate))
                {
                        filterdate += string.Format(" {0}<='{1}' "
                        , Common.Data.Service.date_Field
                        , toDate);   
                }
            }
            if (!string.IsNullOrEmpty(toDate) & !string.IsNullOrEmpty(fromDate))
            {
                if (Validate_Date(toDate))
                {
                    filterdate += string.Format(" and  {0}<='{1}' "
                        , Common.Data.Service.date_Field
                        , toDate);
                }
            }
            if (!string.IsNullOrEmpty(txtQuantity.Text)) filterQuantity=txtQuantity.Text;
            else filterQuantity=" 0 "; 
            DataSet ds = new DataSet();
            try
            {
                ds = new BLL.UserBLL().Get_User_by_Service(filterdate, filterQuantity);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Clear_Fields();
            }
            catch(Exception ex)
            {
                lblErr.Visible = true;
                lblErr.Text = ex.Message;
                Clear_Fields();
            }
        }

         public bool Validate_Date(string date)
        {
            if (!Regex.IsMatch(date, @"^[1-4]\d{3}\/((0?[1-6]\/((3[0-1])|([1-2][0-9])|(0?[1-9])))|((1[0-2]|(0?[7-9]))\/(30|([1-2][0-9])|(0?[1-9]))))$"))
            {
               lblErr.Visible=false;
               return true;
            }
           //else lblErr.Text="تاریخ را به طور صحیح وارد نمایید";
           return true;
        }

         public void Clear_Fields()
         {
           
             txtQuantity.Text = "";
             
         }

         protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
         {
             GridView1.PageIndex = e.NewPageIndex;
             DataSet ds = new BLL.UserBLL().Get_User_by_Service(filterdate, filterQuantity);
             GridView1.DataSource = ds;
             GridView1.DataBind();
         }

        
    }
}