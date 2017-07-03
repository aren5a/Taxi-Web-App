using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
  public  class Service
    {
      public const string TableName = "Service_Tbl";
      public const string ViewName = "View_Service_Info";
      public const string sp_subBalanceName = "[dbo].[sp_subBalance]";

      public const string service_ID_Field = "service_ID";
      public const string userid_Field = "userid";
      public const string name_Field = "Name";
      public const string l_name_Field = "l_name";
      public const string Tell_Num_Field = "Tell_Num";
      public const string date_Field = "date";
      public const string time_Field = "time";
      public const string Driver_id_Field = "Driver_id";
      public const string Dest_Address_Field = "Dest_Address";
      public const string Dest_pos_y_Field = "dest_pos_y";
      public const string Dest_pos_x_Field = "dest_pos_x";
      public const string Orig_Address_Field = "Orig_Address";
      public const string Orig_pos_y_Field = "orig_pos_y";
      public const string Orig_pos_x_Field = "orig_pos_x";
      public const string Cost_Field = "Cost";

      
        private int _service_ID;
        public int service_ID
        {
            get { return _service_ID; }
            set { _service_ID = value; }
        }
        private int _userid;
        public int userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _l_name;
        public string l_name
        {
            get { return _l_name; }
            set { _l_name = value; }
        }
        private string _tell_Num;
        public string tell_Num
        {
            get { return _tell_Num; }
            set { _tell_Num = value; }
        }
        private string _date;
        public string date
        {
            get { return _date; }
            set { _date = value; }
        }
        private string _time;
        public string time
        {
            get { return _time; }
            set { _time = value; }
        }
        private int _Driver_id;
        public int  Driver_id
        {
            get { return _Driver_id; }
            set { _Driver_id = value; }
        }
        private string _dest_address;
        public string dest_address
        {
            get { return _dest_address; }
            set { _dest_address = value; }
        }
        private int _dest_pos_y;
        public int  dest_pos_y
        {
            get { return _dest_pos_y; }
            set { _dest_pos_y = value; }
        }
        private int _dest_pos_x;
        public int  dest_pos_x
        {
            get { return _dest_pos_x; }
            set { _dest_pos_x = value; }
        }
        private string _Orig_address;
        public string Orig_address
        {
            get { return _Orig_address; }
            set { _Orig_address = value; }
        }
        private double _orig_pos_y;
        public double orig_pos_y
        {
            get { return _orig_pos_y; }
            set { _orig_pos_y = value; }
        }
        private double _orig_pos_x;
        public double orig_pos_x
        {
            get { return _orig_pos_x; }
            set { _orig_pos_x = value; }
        }
        private int _Cost;
        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }
    }
}
