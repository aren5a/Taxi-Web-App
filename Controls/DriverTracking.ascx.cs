using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AspMap;
using AspMap.Web;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace Taxi.WebApp.Controls
{
    public partial class DriverTracking : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            map.MapUnit = MeasureUnit.Degree;
            map.ScaleBar.Visible = true;
            map.ScaleBar.BarUnit = UnitSystem.Imperial;
            if (!IsPostBack) map.EnableAnimation = true;
            AddMapLayers();    
        }

        protected void map_RefreshAnimationLayer(object sender, AspMap.Web.RefreshAnimationLayerArgs e)
        {
            AddMapLayers();
            e.NeedRefreshMap = TrackVehicles();
        }

        protected void Page_PreRender(object sender, System.EventArgs e)
        {
            TrackVehicles();
        }

        bool TrackVehicles()
        {
            AspMap.Points path = null;

            AspMap.Point vehicleLocation = GetVehicleCoordinates(ref path);

            GeoEvent geoEvent = new GeoEvent();

            geoEvent.Location = vehicleLocation;
            geoEvent.ImageUrl = "Images/Taxi-icon.png";
            geoEvent.ImageWidth = 20;
            geoEvent.ImageHeight = 20;
            geoEvent.ImageStyle.BorderColor = Color.Red;
            geoEvent.ImageStyle.BorderWidth = Unit.Pixel(1);
            geoEvent.Label = "تاکسی";
            geoEvent.LabelStyle.BackColor = Color.Yellow;
            geoEvent.Tooltip = "تاکسی";

            geoEvent.Path = path;
            geoEvent.PathColor = Color.Yellow;
            geoEvent.PathWidth = 2;

            map.AnimationLayer.Add(geoEvent);
            return false;
        }

        void AddMapLayers()
        {
            string LayerFolder = MapPath("../Images/TehMap/");

            AspMap.Layer layer = new AspMap.Layer();
            layer = map.AddLayer(LayerFolder + "aerialphoto1.tif");
            layer.LabelField = "NAME";
            layer.Symbol.Size = 2;
            layer.Symbol.LineColor = Color.FromArgb(199, 172, 116);
            layer.Symbol.FillColor = Color.FromArgb(242, 236, 223);
        }


        protected void zoomFull_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            map.ZoomFull();
        }

        // For demostration purposes, get GPS coordinates (X/Y) of the vehicle from a text file.
        AspMap.Point GetVehicleCoordinates(ref AspMap.Points path)
        {
            string Add = Server.MapPath("TrackData/vehicle_points.txt");
            StreamReader reader = File.OpenText(Add);

            string line;
            AspMap.Points points = new AspMap.Points();

            while ((line = reader.ReadLine()) != null)
            {
                string[] coords = line.Split(' ');
                if (coords[0] != "") points.Add(Convert.ToDouble(coords[0], NumberFormatInfo.InvariantInfo), Convert.ToDouble(coords[1], NumberFormatInfo.InvariantInfo));
            }

            reader.Close();

            int position = 0;
            if (Session["position"] != null)
                position = Convert.ToInt32(Session["position"]);

            if (position >= points.Count)
                position = 0;

            Session["position"] = Convert.ToString(position + 1);

            AspMap.Point currentLocation = points[position];

            // Remove unnecesary points
            for (int i = points.Count - 1; i > position; i--) points.Remove(i);
            path = points;
            return currentLocation;
        }
        protected void map_PointTool(object sender, AspMap.Web.PointToolEventArgs e)
        {
            map.MapShapes.Clear();

            MapShape mapShape = map.MapShapes.Add(e.Point);
            mapShape.Symbol.Size = 10;
            mapShape.Symbol.FillColor = Color.Red;
        }
    }
}