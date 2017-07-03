using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Runtime.InteropServices;


namespace Taxi.DAL
{
    public class UserDAL : DALBase
    {

        public DataSet Get_User_by_Service(string filterDate,string filterQuantity)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand())
            {
                string text=string.Format("SELECT  tbl.UserName,tbl.Name,tbl.L_Name,tbl.Email,tbl.Tell_Num,tbl.Address,  COUNT(tbl.UserName) AS 'countf' FROM  (select * from {0}"
                                            ,Common.Data.User.ViewName);
                if (!string.IsNullOrEmpty(filterDate)) { text += " where " + filterDate ; };
                    text +=string.Format( " )  as tbl GROUP BY tbl.Name, tbl.L_Name, tbl.UserName,tbl.Email,tbl.Tell_Num,tbl.Address HAVING (tbl.UserName  != 'null' and COUNT(tbl.UserName)>= {0} )"
                        ,filterQuantity);
                    cmd.CommandText = text;
                    cmd.Connection = this.GetConnection();
                    cmd.Connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    try
                    {
                        adapter.Fill(ds, Common.Data.Service.ViewName);
                    }
                    catch(Exception ex)
                    {
                        Common.GeneralException ex1 = new Common.GeneralException(Common.TaxiResource.User_by_Service_Date_err, ex);
                        throw ex1;
                    }
            }
            return ds;

        }
        //---------------------------------------------------------------------------------------------

        public ArrayList Get_Usernames()
        {
            ArrayList arraylist = new ArrayList();
            using (SqlCommand cmd = new SqlCommand())
            {
                string cmdString = string.Format("Select {0} from {1}"
                    ,Common.Data.User.username_Field
                    ,Common.Data.User.TableName);



                cmd.CommandText = cmdString;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Common.Data.User user = new Common.Data.User();
                    object o = reader[Common.Data.User.username_Field];
                    if (o != null) user.username = o.ToString();


                    arraylist.Add(user.username);
                }
                return arraylist;
            }

            
        }
        
      //---------------------------------------Get Username by Filter Method--------------------------------------       


        public IList<Common.Data.User> GetUserbyFilter(ArrayList field, ArrayList value)
        {
            IList<Common.Data.User> list = new List<Common.Data.User>(23);
            using (SqlCommand cmd = new SqlCommand())
            {

                string cmdstring = string.Format("Select * from {0}",
                    Common.Data.User.TableName);

                
                if (field.Count != 0 && value.Count != 0)
                {
                        SqlParameter param;

                        if (field[0].ToString() == "password") cmdstring += " and " + field[0] + " = hashbytes('sha1', @Value0)";
                        else cmdstring += " where " + field[0] + "= @value0";
                        param = new SqlParameter("@Value0", value[0]);
                        param.SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.Add(param);
                 

                    if (field.Count > 1 && value.Count > 1)
                    {
                        for (int i = 1; field.Count > i & value.Count > i ; i++)
                        {
                            if (field[i].ToString() == "password") cmdstring += " and " + field[i] + " = hashbytes('sha1', '" + value[i] + "')";
                            else cmdstring += " and " + field[i] + " = @Value" + i;
                                param = new SqlParameter("@Value" + i, value[i]);
                                param.SqlDbType = SqlDbType.NVarChar;
                                cmd.Parameters.Add(param);
                        }
                     }     
                }

                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Common.Data.User user = new Common.Data.User();
                    object o = reader[Common.Data.User.UserID_Field];
                    if (o != null) user.UserID = int.Parse(o.ToString());

                    o = reader[Common.Data.User.username_Field];
                    if (o != null) user.username = o.ToString();

                    o = reader[Common.Data.User.password_Field];
                    if (o != null) user.password = o.ToString();

                    o = reader[Common.Data.User.user_type_id_Field];
                    if (o != null) user.user_type_id = int.Parse(o.ToString());

                    o = reader[Common.Data.User.name_Field];
                    if (o != null) user.name = o.ToString();

                    o = reader[Common.Data.User.l_name_Field];
                    if (o != null) user.l_name = o.ToString();

                    o = reader[Common.Data.User.email_Field];
                    if (o != null) user.email = o.ToString();

                    o = reader[Common.Data.User.tell_num_Field];
                    if (o != null) user.tell_num = o.ToString();

                    o = reader[Common.Data.User.address_Field];
                    if (o != null) user.address = o.ToString();

                    o = reader[Common.Data.User.Orig_pos_X_Field];
                    if (o != null) user.Orig_pos_X = o.ToString();

                    o = reader[Common.Data.User.Orig_pos_Y_Field];
                    if (o != null) user.Orig_pos_Y = o.ToString();

                    o = reader[Common.Data.User.balance_Field];
                    if (o.ToString() != "") user.balance = int.Parse(o.ToString());

                    o = reader[Common.Data.User.last_charge_Field];
                    if (o != null) user.last_charge = o.ToString();


                    list.Add(user);
                }

            }
            return list;
        }


        //-----------------------------------------Insert new User Method----------------------------------------

        public bool Insert(Common.Data.User user)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("insert into {0} ({1}, {2}, {3}, {4} ,{5} ,{6} ,{7} ,{8} ,{9} ,{10} ) values (@{1},hashbytes('sha1',@{2}), @{3}, @{4}, @{5} ,@{6} ,@{7} ,@{8} ,@{9} ,@{10} )"
                                            , Common.Data.User.TableName
                                            , Common.Data.User.username_Field
                                            , Common.Data.User.password_Field
                                            , Common.Data.User.user_type_id_Field
                                            , Common.Data.User.name_Field
                                            , Common.Data.User.l_name_Field
                                            , Common.Data.User.email_Field
                                            , Common.Data.User.tell_num_Field
                                            , Common.Data.User.address_Field
                                            , Common.Data.User.Orig_pos_X_Field
                                            , Common.Data.User.Orig_pos_Y_Field
                                            , Common.Data.User.balance_Field
                                            , Common.Data.User.last_charge_Field);
                cmd.CommandText = text;

                AddParameters(cmd, user);

                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                //try
                //{
                    cmd.ExecuteNonQuery();
                    return true;
                //}
                //catch (Exception ex)
                //{
                //    Common.GeneralException ex1 = new Common.GeneralException(Common.TaxiResource.DBError, ex);
                //    throw ex1;
                //}
            }
        }



        //----------------------------------------Update User info Method----------------------------------------

        public bool Update(Common.Data.User user)
        {


            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("Update {0} set {2}=@{2}, {3}=hashbytes('sha1',@{3}) , {4}=@{4}, {5}=@{5}, {6}=@{6}, {7}=@{7}, {8}=@{8}, {9}=@{9} , {10}=@{10} where {1} = @{1}"
                                            , Common.Data.User.TableName
                                            , Common.Data.User.UserID_Field
                                            , Common.Data.User.username_Field
                                            , Common.Data.User.password_Field
                                            , Common.Data.User.Orig_pos_Y_Field
                                            , Common.Data.User.name_Field
                                            , Common.Data.User.l_name_Field
                                            , Common.Data.User.email_Field
                                            , Common.Data.User.tell_num_Field
                                            , Common.Data.User.address_Field
                                            ,Common.Data.User.Orig_pos_X_Field);
                cmd.CommandText = text;
                AddParameters(cmd, user);
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

        //---------------------------------Charge User Method------------------------------------

        public bool Charge_User(Common.Data.User user , int charge_ammount)
        {

            

            using (SqlCommand cmd = new SqlCommand())
            {

                SqlParameter param = new SqlParameter("@" + Common.Data.User.balance_Field, user.balance += charge_ammount);
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@" + Common.Data.User.last_charge_Field, DateTime.Now.ToString());
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                string text = string.Format("Update {0} set {1}=@{1} , {2}=@{2}  where UserID={3}"
                                            , Common.Data.User.TableName
                                            , Common.Data.User.balance_Field
                                            , Common.Data.User.last_charge_Field
                                            , user.UserID );

                cmd.CommandText = text;



                

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



        //--------------------------------Add Sql Parameters method------------------------------------

        private void AddParameters(SqlCommand cmd, Common.Data.User user)
        {

            SqlParameter param = new SqlParameter("@" + Common.Data.User.UserID_Field, user.UserID);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.username_Field, user.username);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.password_Field, user.password);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.user_type_id_Field, user.user_type_id);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.name_Field, user.name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.l_name_Field, user.l_name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.email_Field, user.email);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.tell_num_Field, user.tell_num);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.address_Field, user.address);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.Orig_pos_X_Field, user.Orig_pos_X);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.User.Orig_pos_Y_Field, user.Orig_pos_Y);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);



        }

    }
}



