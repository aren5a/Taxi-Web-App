using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Taxi.DAL
{
    public class UserBalanceDAL : DALBase
    {
        public Common.Data.User_Balance Get_Charge([Optional] int UserID)
        {
            Common.Data.User_Balance User_Bal = new Common.Data.User_Balance();

            using (SqlCommand cmd = new SqlCommand())
            {

                string cmdstring = string.Format("Select * from {0} ",
                                             Common.Data.User_Balance.TableName);
                if (UserID != 0) cmdstring += " where UserID=" + UserID.ToString();

                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    User_Bal.balance = int.Parse(reader[Common.Data.User_Balance.balance_Field].ToString());
               

                }
            }
            return User_Bal;
        }



        //-----------------------------------------------------------------------------------------------------

        public bool Charge_User(Common.Data.User_Balance User_Bal)
        {
           
            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("insert into {0} ({1}, {2} ) values (@{1}, @{2}) where UserID={3}"
                                            , Common.Data.User_Balance.TableName
                                            , Common.Data.User_Balance.balance_Field
                                            , Common.Data.User_Balance.Last_Change_Field
                                            , User_Bal.UserID

                                            );
                cmd.CommandText = text;

                AddParameters(cmd, User_Bal);

                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Common.GeneralException ex1 = new Common.GeneralException(Common.TaxiResource.DBError, ex);
                    throw ex1;
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------


        private void AddParameters(SqlCommand cmd, Common.Data.User_Balance User_Bal)
        {
            User_Bal = this.Get_Charge(User_Bal.UserID);

            //Add new ammount with previous(if existed)
            SqlParameter param = new SqlParameter("@" + Common.Data.User_Balance.balance_Field, User_Bal.balance += User_Bal.balance );
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            //Put the current date in the sqlparameter 
            param = new SqlParameter("@" + Common.Data.User_Balance.Last_Change_Field, DateTime.Now.ToString());
            param.SqlDbType = SqlDbType.Date; 
            cmd.Parameters.Add(param);

        }


    }
}

