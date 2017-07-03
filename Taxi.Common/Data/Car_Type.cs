using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
    public class Car_Type
    {
        public const string TableName = "Car_Type_Tbl";

        public const string car_type_id_Field = "car_type_id";
        public const string percent_Field = "percent";
        public const string car_name_Field = "car_name";
        

        private int _car_type_id;
        public int car_type_id
        {
            get { return _car_type_id; }
            set { _car_type_id = value; }
        }
        private int _percent;
        public int  percent
        {
            get { return _percent; }
            set { _percent = value; }
        }
        private string _car_name;
        public string car_name
        {
            get { return _car_name; }
            set { _car_name = value; }
        }
    }
}
