using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
   public  class Driver 
    {
       public const string TableName = "Driver_tbl";
       public const string ViewName = "Driver_Info_View";
       public const string ViewName2 = "View_Driver_Info";
       public const string Update_Position_sp_Name = "Update_Driver_Position";
       public const string Update_Is_Active_sp_Name = "dbo.Update_IsActive";

       public const string DriverID_Field = "DriveriD";
       public const string UserID_Field = "UserID";
       public const string Name_field = "Name";
       public const string l_name_field = "L_name";
       public const string email_field = "email";
       public const string tell_num_field = "tell_num";
       public const string address_field = "address";
       public const string employ_date_Field = "employ_date";
       public const string car_type_id_Field = "car_type_id";
       public const string is_active_Field = "is_active";
       public const string pos_x_Field = "pos_x";
       public const string pos_y_Field = "pos_y";



       private int _DriverID;
       public int DriverID
       {
           get { return _DriverID; }
           set { _DriverID = value; }
       }
        private int _UserID;
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _L_name;
        public string L_name
        {
            get { return _L_name; }
            set { _L_name = value; }
        }
        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _tell_num;
        public string tell_num
        {
            get { return _tell_num; }
            set { _tell_num = value; }
        }
        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _employ_date;
        public string employ_date
        {
            get { return _employ_date; }
            set { _employ_date = value; }
        }
        private int _car_type_id;
        public int car_type_id
        {
            get { return _car_type_id; }
            set { _car_type_id = value; }
        }
        private Boolean _is_active;
        public Boolean is_active
        {
            get { return _is_active; }
            set { _is_active = value; }
        }
        private string _is_active_char;
        public string is_active_char
        {
            get { return _is_active_char; }
            set { _is_active_char = value; }
        }
        private double _pos_x;
        public double pos_x
        {
            get { return _pos_x; }
            set { _pos_x = value; }
        }
        private double _pos_y;
        public double pos_y
        {
            get { return _pos_y; }
            set { _pos_y = value; }
        }
    }
}
