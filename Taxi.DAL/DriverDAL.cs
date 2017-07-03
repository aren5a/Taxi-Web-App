using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Taxi.DAL
{
    public class DriverDAL : DALBase
    {
       

        //---------------------------Select All Drivers-------------------------------------


        public IList<Common.Data.Driver> Get_All()
        {
            IList<Common.Data.Driver> list = new List<Common.Data.Driver>(23);
            using (SqlCommand cmd = new SqlCommand())
            {
                string cmdstring;

                cmdstring = string.Format("select * from {0} ",
                    Common.Data.Driver.ViewName);


                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Common.Data.Driver driver = new Common.Data.Driver();

                    object o = reader[Common.Data.Driver.DriverID_Field];
                    if (o != null) driver.DriverID = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.UserID_Field];
                    if (o != null) driver.UserID = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.employ_date_Field];
                    if (o != null) driver.employ_date = o.ToString();

                    o = reader[Common.Data.Driver.car_type_id_Field];
                    if (o != null) driver.car_type_id = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.is_active_Field];
                    if (o != null) driver.is_active = bool.Parse(o.ToString());

                    o = reader[Common.Data.Driver.pos_x_Field];
                    if (o != null) driver.pos_x =double.Parse(o.ToString());

                    o = reader[Common.Data.Driver.pos_y_Field];
                    if (o != null) driver.pos_y =double.Parse( o.ToString());

                    o = reader[Common.Data.Driver.Name_field];
                    if (o != null) driver.Name = o.ToString();

                    o = reader[Common.Data.Driver.l_name_field];
                    if (o != null) driver.L_name = o.ToString();

                    o = reader[Common.Data.Driver.address_field];
                    if (o != null) driver.address = o.ToString();

                    o = reader[Common.Data.Driver.email_field];
                    if (o != null) driver.email = o.ToString();

                    o = reader[Common.Data.Driver.tell_num_field];
                    if (o != null) driver.tell_num = o.ToString();

                    list.Add(driver);
                }

            }
            return list;

        }


        //-----------------------------------------------Select Filtered Drivers--------------------------


            
        public DataSet GetDriverView(string filter)
        {
            DataSet dset = new DataSet();
            using (SqlCommand cmd = new SqlCommand())
            {
                string cmdstring = string.Format("Select * from {0}"
                   , Common.Data.Driver.ViewName2);


                if (!string.IsNullOrEmpty(filter)) cmdstring += " where " + filter;


                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();
                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dset, Common.Data.Driver.ViewName2);
                return dset;
            }
        }



        //-----------------------------------------------Insert Driver---------------------------------

        public bool insertDriver(Common.Data.Driver driver)
        {


            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("INSERT INTO {0} ({1},{2},{3}) VALUES (@{1},@{2},@{3}) select * from {0} where Driverid=SCOPE_IDENTITY()"
                                            , Common.Data.Driver.TableName
                                            , Common.Data.Driver.employ_date_Field
                                            , Common.Data.Driver.car_type_id_Field
                                            , Common.Data.Driver.is_active_Field);
                cmd.CommandText = text;

                AddParameters(cmd, driver);

                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Common.Data.Driver driver2 = new Common.Data.Driver();
                while (reader.Read())
                {
                    driver2.UserID = int.Parse(reader[Common.Data.Driver.UserID_Field].ToString());
                }

                string text2 = string.Format("Update {0} set {2}=@{2}, {3}=@{3}, {4}=@{4}, {5}=@{5}, {6}=@{6} where UserID = {1}"
                            , Common.Data.User.TableName
                            , driver2.UserID
                            , Common.Data.User.name_Field
                            , Common.Data.User.l_name_Field
                            , Common.Data.User.email_Field
                            , Common.Data.User.tell_num_Field
                            , Common.Data.User.address_Field);
                cmd.CommandText = text2;

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
        //---------------------------------------------Delete Specified Driver--------------------------------------------------

        public bool DeleteDriver(int driverID)
        {


            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("Delete from {0}  where {1} = @{1}"
                                            , Common.Data.Driver.TableName
                                            , Common.Data.Driver.DriverID_Field);
                                           
                cmd.CommandText = text;

                SqlParameter param = new SqlParameter("@" + Common.Data.Driver.DriverID_Field, driverID);
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

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

        //-------------------------------------------Active or Deactive a driver------------------------------------------------

        public bool Update_Activate(int driverID)
        {


            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("update {0} set {1}=  case when {1}='false' then 'true' else  'false' end  where {2}=@{2}"
                                            , Common.Data.Driver.TableName
                                            , Common.Data.Driver.is_active_Field
                                            , Common.Data.Driver.DriverID_Field);
                cmd.CommandText = text;

                SqlParameter param = new SqlParameter("@" + Common.Data.Driver.DriverID_Field, driverID);
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
        //---------------------------------------------Update Driver Position---------------------------------------------------
        public IList<Common.Data.Driver>  Update_Position()
        {

            IList<Common.Data.Driver> list = new List<Common.Data.Driver>();
            using (SqlCommand cmd = new SqlCommand())
            {

                string text = string.Format("Exec {0} '##Temp' Select ##Temp.*, {1}.{3} , {1}.{4} From ##Temp left outer join {1} on {1}.{2} = ##Temp.{2} where is_Active = '1' "
                                            ,Common.Data.Driver.Update_Position_sp_Name
                                            ,Common.Data.User.TableName
                                            ,Common.Data.User.UserID_Field
                                            ,Common.Data.User.name_Field
                                            ,Common.Data.User.l_name_Field);
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = text;

                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                 
                    Common.Data.Driver driver = new Common.Data.Driver();
                    
                    object o = reader[Common.Data.Driver.DriverID_Field];
                    if (o != null) driver.DriverID = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.UserID_Field];
                    if (o != null) driver.UserID = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.employ_date_Field];
                    if (o != null) driver.employ_date = o.ToString();

                    o = reader[Common.Data.Driver.car_type_id_Field];
                    if (o != null) driver.car_type_id = int.Parse(o.ToString());

                    o = reader[Common.Data.Driver.is_active_Field];
                    if (o != null) driver.is_active = bool.Parse(o.ToString());

                    o = reader[Common.Data.Driver.pos_x_Field];
                    if (o != null) driver.pos_x = double.Parse(o.ToString());

                    o = reader[Common.Data.Driver.pos_y_Field];
                    if (o != null) driver.pos_y = double.Parse(o.ToString());

                    o = reader[Common.Data.Driver.Name_field];
                    if (o != null) driver.Name = o.ToString();

                    o = reader[Common.Data.Driver.l_name_field];
                    if (o != null) driver.L_name = o.ToString();
                    
                    list.Add(driver);   
                }
               
            }
            return list;
        }


        //---------------------------------------Add Driver and User SQL Parameters---------------------------------------------


        private void AddParameters(SqlCommand cmd, Common.Data.Driver driver)
        {

            SqlParameter param = new SqlParameter("@" + Common.Data.Driver.employ_date_Field, driver.employ_date);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.car_type_id_Field, driver.car_type_id);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.is_active_Field, driver.is_active);
            param.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(param);

            double x = new Random().NextDouble() * new Random().Next(-3100, -8);
            param = new SqlParameter("@" + Common.Data.Driver.pos_x_Field, x);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            double y = new Random().NextDouble() * new Random().Next(4, 3700);
            param = new SqlParameter("@" + Common.Data.Driver.pos_y_Field, y);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.Name_field, driver.Name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.l_name_field, driver.L_name);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.email_field, driver.email);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.tell_num_field, driver.tell_num);
            param.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.Driver.address_field, driver.address);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);


        }


    }
}
