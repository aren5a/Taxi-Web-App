using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Taxi.BLL
{
  public class UserBalanceBLL
    {
      public Common.Data.User_Balance Get_Charge([Optional] int userId)
      {
          return new DAL.UserBalanceDAL().Get_Charge(userId);
      }
      public bool Charge_User(Common.Data.User_Balance user_bal)
      {
          if (user_bal != null)
          {
              new DAL.UserBalanceDAL().Charge_User(user_bal);
              return true;
          }
          else return false;
      }

    }
}
