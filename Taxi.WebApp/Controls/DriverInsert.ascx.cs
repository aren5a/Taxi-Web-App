using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Taxi.WebApp.Controls
{
    public partial class DriverInsert : System.Web.UI.UserControl
    {
        static string filter;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Visible = false;
            }
        }

        protected void bttEntDate_Click(object sender, EventArgs e)
        {
            txtEmpDate.Text = new Common.Utility().Set_Shamsi_Date().ToString();
        }

        protected void bttInsert_Click(object sender, EventArgs e)
        {
           Common.Data.Driver driver = new Common.Data.Driver();
           driver.Name= txtName.Text;
           driver.L_name = txtlname.Text;
           driver.email = txtEmail.Text;
           driver.tell_num = txttellnum.Text;
           driver.address = txtAddress.Text;
           driver.car_type_id = int.Parse(DropDownList1.SelectedValue);
           driver.employ_date = txtEmpDate.Text;
           if (IsValidToDo())
           {
               new BLL.DriverBLL().InsertDriver(driver);
               lblErr.Visible = false;
           }
           else lblErr.Text = "فیلد های ستاره دار باید پر شود";
        }
        protected void BttSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            filter = string.Empty;
            string text = txtSearch.Text;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                filter = string.Format("{0} like '%{1}%'", Common.Data.Driver.Name_field, text);
                filter += string.Format("or {0} like '%{1}%'", Common.Data.Driver.l_name_field, text);
                filter += string.Format("or {0} like '%{1}%'", Common.Data.Car_Type.car_name_Field, text);
            }
            ds = new BLL.DriverBLL().GetDriverView(filter);
            gvDriver.DataSource = ds;
            gvDriver.DataBind();
        }



        protected void btnRemove_Command(Object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            int driverId = int.Parse(e.CommandArgument.ToString());
            if (driverId != 0)
            {
                new BLL.DriverBLL().DeleteDriver(driverId);
                lblMsg.Visible = true;
                lblMsg.Text = "راننده مورد نظر حذف شد";
            }
        }

        protected void btnActivity_Command(Object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            int driverId = int.Parse(e.CommandArgument.ToString());
            if (driverId != 0)
               {
                  new BLL.DriverBLL().Update_Activate(driverId);
               }
    
            lblMsg.Text = "وضعیت راننده مورد نظر تغییر یافت";
        }
        protected bool IsValidToDo()
        {
            bool Valid = true;
            if(string.IsNullOrEmpty(txtName.Text)) Valid =false;
            if (string.IsNullOrEmpty(txtlname.Text)) Valid = false;
            if (string.IsNullOrEmpty(txttellnum.Text)) Valid = false;
            if (string.IsNullOrEmpty(txtAddress.Text)) Valid = false;
            if (string.IsNullOrEmpty(txtEmpDate.Text)) Valid = false;
            return Valid;  
        }



        protected void gvDriver_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDriver.PageIndex = e.NewPageIndex;
            DataSet ds = new BLL.DriverBLL().GetDriverView(filter);
            gvDriver.DataSource = ds;
            gvDriver.DataBind();
        }
    }
}