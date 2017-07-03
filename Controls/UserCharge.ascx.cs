using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Taxi.WebApp.Controls
{
    public partial class UserCharge : System.Web.UI.UserControl
    {
        static IList<Common.Data.User> user = new List<Common.Data.User>(1);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Disable_Charge();
            }
        }

        protected void BTTSrchName_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList field = new ArrayList();
                ArrayList value = new ArrayList();


                if (!string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    field.Add("username");
                    value.Add(txtUsername.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    field.Add("Name");
                    value.Add(txtName.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtLName.Text.Trim()))
                {
                    field.Add("L_Name");
                    value.Add(txtLName.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtTell.Text.Trim()))
                {
                    field.Add("Tell_Num");
                    value.Add(txtTell.Text.Trim());
                }
                if (field.Count != 0 && value.Count != 0)
                {
                    field.Add("User_type_ID");
                    value.Add("3");
                    user = new BLL.UserBLL().GetUserbyFilter(field, value);
                }

                if (user.Count == 0)
                {
                    Disable_Charge();
                    throw new Common.GeneralException(Common.TaxiResource.User_NotFound_Err);
                }

                //Visible Labels and Enable charge 
                Enable_Charge();

                //Put value in labels 

                LBLUsername2.Text = user[0].username;
                LBLUserCharge2.Text = user[0].balance.ToString();

                //Clear fields
                txtUsername.Text = "";
                txtName.Text = "";
                txtLName.Text = "";
                txtTell.Text = "";
            }
            catch(Exception ex)
            {
                lblSrchErr.Text=ex.Message;
            }
        }

        protected void bttCharge_Click(object sender, EventArgs e)
        {
            try
            {
                new BLL.UserBLL().charge_user(user[0], int.Parse(TXTChargeAmount.Text));
                LBLUserCharge2.Text = user[0].balance.ToString();
                TXTChargeAmount.Text = "";
            }
            catch (Exception ex)
            {
                lblChargeErr.Text = ex.Message;
            }
        }
        protected void Disable_Charge()
        {
            LBLUserCharge.Visible = false;
            LBLUsername.Visible = false;
            LBLUserCharge2.Visible = false;
            LBLUsername2.Visible = false;
            TXTChargeAmount.Enabled = false;
            bttCharge.Enabled = false;
        }
        protected void Enable_Charge()
        {
            lblChargeErr.Text = "";
            lblSrchErr.Text = "";
            LBLUserCharge.Visible = true;
            LBLUsername.Visible = true;
            LBLUserCharge2.Visible = true;
            LBLUsername2.Visible = true;
            TXTChargeAmount.Enabled = true;
            bttCharge.Enabled = true;
        }
    }
}