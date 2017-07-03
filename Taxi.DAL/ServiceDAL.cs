using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Taxi.DAL
{
    public class ServiceDAL : DALBase
    {
        public DataSet GetByFilter(string filter, string orderbye)
        {
            DataSet dset = new DataSet();
            
            using ( SqlCommand cmd = new SqlCommand())
            {
                string cmdstring = string.Format("Select * from {0}", Common.Data.Service.ViewName);
                if (!string.IsNullOrEmpty(filter)) cmdstring += " where " + filter;
                if (!string.IsNullOrEmpty(orderbye)) cmdstring += " order by " + orderbye;
                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dset, Common.Data.Service.ViewName);
            }
            return dset;
        }




        public DataSet GrtAll() 
        {
            return GetByFilter(null, null);
        }
    


        public bool Insert(Common.Data.Service service)
        {
           
            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("insert into {0} ({1}, {2}, {3}, {4} ,{5} ,{6} ,{7} ,{8} ,{9} ,{10},{11}) values (Case when @{1}=0 then NULL else @{1} end, @{2}, @{3}, @{4}, @{5} ,@{6} ,@{7} ,@{8} ,@{9} ,@{10} , 0 ) exec {12} @{6} "
                                            , Common.Data.Service.TableName
                                            , Common.Data.Service.userid_Field
                                            , Common.Data.Service.name_Field
                                            , Common.Data.Service.l_name_Field
                                            , Common.Data.Service.date_Field
                                            , Common.Data.Service.time_Field
                                            , Common.Data.Service.Driver_id_Field                  
                                            , Common.Data.Service.Dest_Address_Field
                                            , Common.Data.Service.Orig_Address_Field
                                            , Common.Data.Service.Orig_pos_x_Field
                                            , Common.Data.Service.Orig_pos_y_Field
                                            , Common.Data.Service.Cost_Field
                                            , Common.Data.Driver.Update_Is_Active_sp_Name);
                cmd.CommandText = text;
                cmd.CommandType = CommandType.Text;

                AddParameters(cmd, service);

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

        public bool Update(Common.Data.Service service)
        {
            
            
            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("Update {0} set {2}=@{2}, {3}=@{3}, {4}=@{4}, {5}=@{5}, {6}=@{6}, {7}=@{7}, {8}=@{8}, {9}=@{9}, {10}=@{10}, {11}=@{11}, {12}=@{12}, {13}=@{13} where {1} = @{1})"
                                            , Common.Data.Service.ViewName
                                            , Common.Data.Service.service_ID_Field
                                            , Common.Data.Service.userid_Field
                                            , Common.Data.Service.name_Field
                                            , Common.Data.Service.l_name_Field
                                            , Common.Data.Service.date_Field
                                            , Common.Data.Service.time_Field
                                            , Common.Data.Service.Driver_id_Field
                                            , Common.Data.Service.Dest_Address_Field
                                            , Common.Data.Service.Dest_pos_x_Field
                                            , Common.Data.Service.Dest_pos_y_Field
                                            , Common.Data.Service.Orig_Address_Field
                                            , Common.Data.Service.Orig_pos_x_Field
                                            , Common.Data.Service.Orig_pos_y_Field);
                cmd.CommandText = text;
                AddParameters(cmd, service);
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
        public bool Update_User_Cost(int userID,decimal cost)
        {
            
            using (SqlCommand cmd = new SqlCommand())
            {
                
                string text = string.Format("{0}"
                                ,Common.Data.Service.sp_subBalanceName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = text;
                cmd.Parameters.AddWithValue("@cost",cost);
                cmd.Parameters.AddWithValue("@userID", userID);
                SqlParameter retval = cmd.Parameters.Add("@bit", SqlDbType.Int);
                retval.Direction = ParameterDirection.Output;


                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                int retunvalue = int.Parse(cmd.Parameters["@bit"].Value.ToString());
                if (retunvalue == 1) return true;
                else return false;   
            }

        }
        public bool Update_Cost(int srviceId, decimal cost)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("update {0} set {1}=@{1}  where {2}=@{2}"
                                            , Common.Data.Service.TableName
                                            , Common.Data.Service.Cost_Field
                                            , Common.Data.Service.service_ID_Field);
                cmd.CommandText = text;
                

                SqlParameter param = new SqlParameter("@" + Common.Data.Service.Cost_Field, cost);
                param.SqlDbType = SqlDbType.Decimal;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@" + Common.Data.Service.service_ID_Field, srviceId);
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

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
        
        public bool Delete(Common.Data.Service service)
        {
            

            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("Delete from {0} where {1} = @{1})"
                                            , Common.Data.Service.ViewName
                                            , Common.Data.Service.service_ID_Field);
                cmd.CommandText = text;

                SqlParameter param = new SqlParameter("@" +Common.Data.Service.service_ID_Field, service.service_ID);
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

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

        
        
        private void AddParameters(SqlCommand cmd, Common.Data.Service service)
        {
            
            SqlParameter param = new SqlParameter("@" + Common.Data.Service.service_ID_Field, service.service_ID);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            
            param = new SqlParameter("@" + Common.Data.Service.userid_Field, service.userid);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.name_Field, service.Name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.l_name_Field, service.l_name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.Tell_Num_Field, service.tell_Num);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.date_Field, new Common.Utility().Set_Shamsi_Date());
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.time_Field, DateTime.Now.ToShortTimeString());
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.Driver_id_Field, service.Driver_id);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" +Common.Data.Service.Dest_Address_Field, service.dest_address);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);


            param = new SqlParameter("@" + Common.Data.Service.Orig_Address_Field,service.Orig_address);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.Orig_pos_x_Field, service.orig_pos_x);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Service.Orig_pos_y_Field, service.orig_pos_y);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);



            
        }

    }
   
}
