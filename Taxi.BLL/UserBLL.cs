using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;

namespace Taxi.BLL
{
    public class UserBLL
    {

        public ArrayList get_usernames()
        {
            return new DAL.UserDAL().Get_Usernames();
        }
        public DataSet Get_User_by_Service(string filterDate, string filterQuantity)
        {
            return new DAL.UserDAL().Get_User_by_Service(filterDate, filterQuantity);
        }
        public IList<Common.Data.User> GetUserbyFilter(ArrayList field, ArrayList value)
        {
            return new DAL.UserDAL().GetUserbyFilter(field, value);
        }
        //public IList<Common.Data.User> GetUserbyFilter(string Field1, string Value1)
        //{
        //    if (Value1 != string.Empty )
        //    {

        //        DAL.UserDAL login = new DAL.UserDAL();
        //        string filter1 = Field1 + "= '" + Value1 + "'";
                
        //        return login.GetUserbyFilter(filter1,null);

        //    }

        //    else return null;


        //}
        public bool insert(Common.Data.User user)
        {
            
            if(ValidateUser(user))
            {
            DAL.UserDAL userdal = new DAL.UserDAL();
            return userdal.Insert(user);
            }
            else
            {
                return false;
            }
        }

        public bool Update(Common.Data.User user)
        {
            if (user != null)
            {
                return new DAL.UserDAL().Update(user);
            }
            else return false;
        }

        public bool charge_user(Common.Data.User user , int charge_ammount)
        {
            return new DAL.UserDAL().Charge_User(user,charge_ammount);
        }

        public bool ValidateUser (Common.Data.User user)
        {
          bool validated = true;
           if(!Regex.IsMatch(user.email,@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") && !Regex.IsMatch(user.tell_num,@"\d{8}"))
            {
              validated=false;
            }

           if (string.IsNullOrEmpty(user.username) & string.IsNullOrEmpty(user.password) & string.IsNullOrEmpty(user.l_name) & string.IsNullOrEmpty(user.tell_num))
            {
              validated =false;
            }
            return validated;
        }

    }
}
