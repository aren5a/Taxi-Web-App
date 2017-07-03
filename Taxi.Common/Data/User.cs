using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
   public class User
    {
       public const string TableName = "User_Tbl";
       public const string ViewName = "dbo.View_User_Service";
       
       public const string UserID_Field = "UserID";
       public const string username_Field = "username";
       public const string password_Field = "password";
       public const string user_type_id_Field = "user_type_id";
       public const string name_Field = "name";
       public const string l_name_Field = "l_name";
       public const string email_Field = "email";
       public const string tell_num_Field = "tell_num";
       public const string address_Field = "address";
       public const string Orig_pos_X_Field = "Orig_pos_X";
       public const string Orig_pos_Y_Field = "Orig_pos_Y"; 
       public const string balance_Field = "balance";
       public const string last_charge_Field = "last_charge";



        private int _UserID;
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private string _username;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _user_type_id;
        public int user_type_id
        {
            get { return _user_type_id; }
            set { _user_type_id = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _l_name;
        public string l_name
        {
            get { return _l_name; }
            set { _l_name = value; }
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
        private string _Orig_pos_X;
        public string Orig_pos_X
        {
            get { return _Orig_pos_X; }
            set { _Orig_pos_X = value; }
        }
        private string _Orig_pos_Y;
        public string Orig_pos_Y
        {
            get { return _Orig_pos_Y; }
            set { _Orig_pos_Y = value; }
        }
        private int _balance;
        public int  balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        private string _last_charge;
        public string last_charge
        {
            get { return _last_charge; }
            set { _last_charge = value; }
        }

    }
}
