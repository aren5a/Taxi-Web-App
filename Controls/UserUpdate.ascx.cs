using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using AspMap;

namespace Taxi.WebApp.Controls
{
    public partial class UserUpdate : System.Web.UI.UserControl
    {
        static Common.Data.User user = new Common.Data.User();
        static Common.Data.User Newuser = new Common.Data.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            map_.MapUnit = MeasureUnit.Degree;
            map_.ScaleBar.Visible = true;
            map_.ScaleBar.BarUnit = UnitSystem.Imperial;

            AddMapLayers();
            
            if (!IsPostBack)
            {
                user = HttpContext.Current.Session["CurrentUser"] as Common.Data.User;
                lblUsername.Text = user.username;
                lblName.Text = user.name;
                lbll_name.Text = user.l_name;
                lblEmail.Text = user.email;
                lblTell.Text = user.tell_num;
                lblAddress.Text = user.address;
                lblOrigX.Text= user.Orig_pos_X;
                lblOrigY.Text = user.Orig_pos_Y;
                Newuser.Orig_pos_X = lblOrigX.Text;
                Newuser.Orig_pos_Y = lblOrigY.Text;

                AspMap.Point point = new AspMap.Point();
                point.X = double.Parse(user.Orig_pos_X);
                point.Y = double.Parse(user.Orig_pos_Y);
                MapShape mapShape = map_.MapShapes.Add(point);
                mapShape.Symbol.Size = 10;
                mapShape.Symbol.FillColor = Color.Red;
            }
        }


        protected void bttEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                Newuser.UserID = user.UserID;
                if (string.IsNullOrEmpty(UserTXT.Text)) { Newuser.username = user.username; } else Newuser.username = UserTXT.Text;
                if (string.IsNullOrEmpty(PassTXT.Text)) { Newuser.password = user.password; } else Newuser.password = PassTXT.Text;
                if (string.IsNullOrEmpty(NameTXT.Text)) { Newuser.name = user.name; } else Newuser.name = NameTXT.Text;
                if (string.IsNullOrEmpty(L_NameTXT.Text)) { Newuser.l_name = user.l_name; } else Newuser.l_name = L_NameTXT.Text;
                if (string.IsNullOrEmpty(EmailTXT.Text)) { Newuser.email = user.email; } else Newuser.email = EmailTXT.Text;
                if (string.IsNullOrEmpty(TellTXT.Text)) { Newuser.tell_num = user.tell_num; } else Newuser.tell_num = TellTXT.Text;
                if (string.IsNullOrEmpty(AddressTXT.Text)) { Newuser.address = user.address; } else Newuser.address = AddressTXT.Text;
                if (string.IsNullOrEmpty(lblOrigX.Text)) { Newuser.Orig_pos_X = "0"; } else Newuser.Orig_pos_X = lblOrigX.Text; ;
                if (string.IsNullOrEmpty(lblOrigY.Text)) { Newuser.Orig_pos_Y = "0"; } else Newuser.Orig_pos_Y = lblOrigY.Text; ;
                new BLL.UserBLL().Update(Newuser);
                HttpContext.Current.Session.Add(Common.Utility.CurrentUserSession, Newuser);
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
            lblOrigX.Text=e.Point.X.ToString();
            lblOrigY.Text=e.Point.Y.ToString();
           
        }

        protected void AddMapLayers()
        {
            string LayerFolder = MapPath("../Images/TehMap/");

            //map_.AddLayer();
            AspMap.Layer layer = new AspMap.Layer();
            layer = map_.AddLayer(LayerFolder + "aerialphoto1.tif");
            layer.LabelField = "NAME";
            layer.Symbol.Size = 2;
            layer.Symbol.LineColor = Color.FromArgb(199, 172, 116);
            layer.Symbol.FillColor = Color.FromArgb(242, 236, 223);
        }
    }
}