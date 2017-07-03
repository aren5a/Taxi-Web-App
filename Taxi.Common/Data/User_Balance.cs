using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
   public class User_Balance
    {

        public const string TableName = "User_Balance_tbl";
       
        public const string UserID_Field = "UserID";
        public const string balance_Field = "balance";
        public const string Last_Change_Field = "Last_Change";


        private int _UserID;
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private int _balance;
        public int balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        private string _Last_Charge;
        public string Last_Charge
        {
            get { return _Last_Charge; }
            set { _Last_Charge = value; }
        }
    }
}
