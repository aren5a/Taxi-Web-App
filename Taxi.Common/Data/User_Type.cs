using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
    public class User_Type
    {
        public const string user_type_id_Field = "user_type_id";
        public const string type_name_Field = "type_name";

        private int _user_type_id;
        public int  user_type_id
        {
            get { return _user_type_id; }
            set { _user_type_id = value; }
        }
        private string _type_name;
        public string  type_name
        {
            get { return _type_name; }
            set { _type_name = value; }
        }

    }
}
