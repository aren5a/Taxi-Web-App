using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using AspMap;
using AspMap.Web;
using System.Drawing;

namespace Taxi.WebApp.Controls
{
    public partial class Register : System.Web.UI.UserControl
    {

      static ArrayList userList = new ArrayList();
      static Common.Data.User user = new Common.Data.User();
      static bool IsAdmin = false;

       protected void Page_Load(object sender, EventArgs e)
        {
            //----Map Params-----------
            map_.MapUnit = MeasureUnit.Degree;
            map_.ScaleBar.Visible = true;
            map_.ScaleBar.BarUnit = UnitSystem.Imperial;

            AddMapLayers();
            //-------------------------
            if (!IsPostBack)
            {
                
                Common.Data.User currentuser = new Common.Data.User();
                currentuser = HttpContext.Current.Session[Common.Utility.CurrentUserSession] as Common.Data.User;
                if (currentuser != null)
                {
                    if (currentuser.user_type_id == 1) { User_TypeList.Visible = true; LBLAcc_Type.Visible = true;  }
                    IsAdmin = true;
                }
                else { user.user_type_id = 3; }
              
                userList = new BLL.UserBLL().get_usernames();                    
            }
            
        }

        protected void UserTXT_TextChanged(object sender, EventArgs e)
        {

            if (new Common.Utility().username_exists(userList, txtUser.Text))
            {

                Username_ErrLBL.Text = "نام کاربری وارد شده وجود دارد";
                Username_ErrLBL.Visible = true;
                txtUser.BorderColor = System.Drawing.Color.Red;
                txtUser.Text = "";


               
            }
            else
            {
                txtUser.BorderColor = System.Drawing.Color.Green;
                Username_ErrLBL.Visible = false;   
            }
        }

        protected void SubButt_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtUser.Text) ||
                   string.IsNullOrEmpty(txtPass.Text) ||
                   string.IsNullOrEmpty(TXTName.Text) ||
                   string.IsNullOrEmpty(TXTL_Name.Text) ||
                   string.IsNullOrEmpty(TXTEmail.Text) ||
                   string.IsNullOrEmpty(TXTTell.Text) ||
                   string.IsNullOrEmpty(TXTAddress.Text) ||
                   string.IsNullOrEmpty(user.Orig_pos_X) ||
                   string.IsNullOrEmpty(user.Orig_pos_Y)) { InfoLBL.Text = "مشخصات کاربری را کامل وارد نمایید"; }

                else
                {
                    user.username = txtUser.Text;
                    user.password = txtPass.Text;
                    if (IsAdmin==true) user.user_type_id = int.Parse(User_TypeList.SelectedValue);
                    user.name = TXTName.Text;
                    user.l_name = TXTL_Name.Text;
                    user.email = TXTEmail.Text;
                    user.tell_num = TXTTell.Text;
                    user.address = TXTAddress.Text;
                    if (IsValidToDo())
                    {
                        new BLL.UserBLL().insert(user);
                        InfoLBL.Visible = false;
                        ClearForm2();
                    }
                    else InfoLBL.Text = "فیلد های ستاره دار باید پر شود";
                }
            }
            catch (Exception ex)
            {
                InfoLBL.Visible = true;
                InfoLBL.Text = ex.Message;
            }

        }

        protected void zoomFull_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            map_.ZoomFull();
        }
        protected void map_PointTool(object sender, AspMap.Web.PointToolEventArgs e)
        {
            map_.MapShapes.Clear();

            MapShape mapShape = map_.MapShapes.Add(e.Point);
            mapShape.Symbol.Size = 10;
            mapShape.Symbol.FillColor = Color.Red;
            user.Orig_pos_X = e.Point.X.ToString();
            user.Orig_pos_Y = e.Point.Y.ToString();

        }

        protected void AddMapLayers()
        {
            string LayerFolder = MapPath("../Images/TehMap/");

            AspMap.Layer layer = new AspMap.Layer();
            layer = map_.AddLayer(LayerFolder + "aerialphoto1.tif");
            layer.LabelField = "NAME";
            layer.Symbol.Size = 2;
            layer.Symbol.LineColor = Color.FromArgb(199, 172, 116);
            layer.Symbol.FillColor = Color.FromArgb(242, 236, 223);
        }

        protected void ClearForm_Click(object sender, EventArgs e)
        {
             txtUser.Text="";
             txtPass.Text="";
             TXTName.Text="";
             TXTL_Name.Text="";
             TXTEmail.Text="";
             TXTTell.Text="";
             TXTAddress.Text = "";
             map_.MapShapes.Clear();
        }

        protected void ClearForm2()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            TXTName.Text = "";
            TXTL_Name.Text = "";
            TXTEmail.Text = "";
            TXTTell.Text = "";
            TXTAddress.Text = "";
        }
        protected bool IsValidToDo()
        {
            bool Valid = true;
            if (string.IsNullOrEmpty(TXTName.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTL_Name.Text)) Valid = false;
            if (string.IsNullOrEmpty(txtPass.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTPassConfirm.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTTell.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTAddress.Text)) Valid = false;
            return Valid;
        }
    }
}