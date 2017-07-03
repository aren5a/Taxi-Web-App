using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AspMap;
using AspMap.Web;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web.SessionState;

namespace Taxi.WebApp.Controls
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {

     static  IList<Common.Data.Driver> Stt_driverList = new List<Common.Data.Driver>(23);
     static IList<Common.Data.User> Userlist = new List<Common.Data.User>();
     static Common.Data.Driver chosenDriver = new Common.Data.Driver();
       
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
                Stt_driverList = new BLL.DriverBLL().Update_Position();
            }
                for (int i = 0; i < Stt_driverList.Count; i++)
                {
                    add_point(Stt_driverList[i].pos_x, Stt_driverList[i].pos_y, Stt_driverList[i]);
                }
        }

        protected void BTTSrchName_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList  field= new ArrayList();
                ArrayList  value= new ArrayList();
                
                if (!string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                 field.Add("username");
                 value.Add(txtUsername.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    field.Add( "Name");
                    value.Add(txtName.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtLName.Text.Trim()))
                {
                    field.Add("L_Name");
                    value.Add( txtLName.Text.Trim());
                }
                else if (!string.IsNullOrEmpty(txtTell.Text.Trim()))
                {
                   field.Add("Tell_Num");
                   value.Add( txtTell.Text.Trim());
                }
                if (field.Count != 0 && value.Count != 0)
                {
                    field.Add("User_type_ID");
                    value.Add("3");
                    Userlist = new BLL.UserBLL().GetUserbyFilter(field, value);
                }

                if (Userlist.Count == 0) { throw new Common.GeneralException(Common.TaxiResource.User_NotFound_Err); }

                txtUsername2.Text = Userlist[0].username;
                TXTName2.Text = Userlist[0].name;
                TXTLName2.Text = Userlist[0].l_name;
                txtTell2.Text = Userlist[0].tell_num;
                TXTOrigAdd.Text = Userlist[0].address;
                txtorigX.Text = Userlist[0].Orig_pos_X;
                txtorigY.Text = Userlist[0].Orig_pos_Y;
                LBLBalance.Text = Userlist[0].balance.ToString();

                txtUsername.Text = "";
                txtName.Text = "";
                txtLName.Text = "";
                txtTell.Text = "";
                lblSrchErr.Text = "";

                //-------Show the Position on the Map if Exists---------
                if (!string.IsNullOrEmpty(txtorigX.Text) && !string.IsNullOrEmpty(txtorigY.Text))
                {
                    map_.MapShapes.Clear();

                    AspMap.Point pointOrig = new AspMap.Point();
                    pointOrig.X = double.Parse(Userlist[0].Orig_pos_X);
                    pointOrig.Y = double.Parse(Userlist[0].Orig_pos_Y);

                    MapShape mapShape = map_.MapShapes.Add(pointOrig);
                    mapShape.Symbol.Size = 10;
                    mapShape.Symbol.FillColor = Color.Red;

                    //-------Find The Closest Driver(Registered User)------
                    chosenDriver = new Common.Utility().Find_Driver(Stt_driverList, pointOrig);
                    add_point(chosenDriver.pos_x, chosenDriver.pos_y, chosenDriver);
                    lblDriver.Text = chosenDriver.Name + ' ' + chosenDriver.L_name;
                    DriverID.Value = chosenDriver.DriverID.ToString();
                }
            }
            catch (Exception ex)
            {
                lblSrchErr.Text = ex.Message;
                txtUsername.Text = "";
                txtName.Text = "";
                txtLName.Text = "";
                txtTell.Text = "";
            }

        }

        protected void BttSubmit_Click(object sender, EventArgs e)
        {
            Common.Data.User user= new Common.Data.User();
            user=HttpContext.Current.Session[Common.Utility.CurrentUserSession] as Common.Data.User;
            Common.Data.Service service = new Common.Data.Service();
            service.Driver_id = int.Parse(DriverID.Value);
            service.Name = TXTName2.Text;
            service.l_name = TXTLName2.Text;
            service.tell_Num = txtTell2.Text;
            service.Orig_address = TXTOrigAdd.Text;
            service.orig_pos_x = Double.Parse(txtorigX.Text);
            service.orig_pos_y = Double.Parse(txtorigY.Text);
            service.dest_address = TXTDestAdd.Text;
           

            if (Userlist.Count != 0)
            {
                service.userid = Userlist[0].UserID;
            }
            if (IsValidToDo())
            {
                try
                {
                    if (lblDriver.Text != "") 
                    {
                        new BLL.ServiceBLL().Insert(service);
                        if (user.user_type_id == 1) Response.Redirect("ServiceSubmite(Admin).aspx");
                        else Response.Redirect("ServiceSubmit.aspx");
                    }
                    else lblErr.Text = "راننده آزاد موجود نیست";
                    
                }
                catch(Exception ex)
                {
                    lblErr.Text = ex.Message;
                }
            }
            else lblErr.Text = "فیلد های ستاره دار باید پر شود";
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
            txtorigX.Text = e.Point.X.ToString();
            txtorigY.Text = e.Point.Y.ToString();
            
            //-------Find Closest Driver(Not Registered User)-----------
            chosenDriver = new Common.Utility().Find_Driver(Stt_driverList, e.Point);
            add_point(chosenDriver.pos_x, chosenDriver.pos_y, chosenDriver);
            lblDriver.Text = chosenDriver.Name + ' ' + chosenDriver.L_name;
            DriverID.Value = chosenDriver.DriverID.ToString(); 
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

        protected void add_point(double X, double Y,Common.Data.Driver driverInfo)
        {
            AspMap.Point point = new AspMap.Point();
            point.X = X;
            point.Y = Y;

            GeoEvent geoEvent = new GeoEvent();
            geoEvent.Location = point;
            geoEvent.ImageUrl = "Images/Taxi-icon.png";
            geoEvent.ImageWidth = 20;
            geoEvent.ImageHeight = 20;
            geoEvent.ImageStyle.BorderColor = Color.Red;
            geoEvent.ImageStyle.BorderWidth = Unit.Pixel(1);
            geoEvent.Label = driverInfo.Name + " " + driverInfo.L_name;
            geoEvent.LabelStyle.BackColor = Color.Yellow;
            geoEvent.Tooltip = driverInfo.Name + " " + driverInfo.L_name;
            map_.AnimationLayer.Add(geoEvent);
        }
        protected bool IsValidToDo()
        {
            bool Valid = true;
            if (string.IsNullOrEmpty(TXTName2.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTLName2.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTDestAdd.Text)) Valid = false;
            if (string.IsNullOrEmpty(TXTOrigAdd.Text)) Valid = false;
            return Valid;
        }
        protected void Clear_Fields()
        {
            TXTName2.Text = "";
            TXTLName2.Text = "";
            txtTell2.Text = "";
            TXTOrigAdd.Text = "";
            txtUsername2.Text = "";
            txtorigX.Text = "";
            txtorigY.Text = "";
            TXTDestAdd.Text = "";
        }
    }
}