using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Taxi.DAL
{
    public class NewsDAL :DALBase
    {
        public Common.Data.News Get_News(string orderbye)
        {
            Common.Data.News News = null;
            using (SqlCommand cmd = new SqlCommand())
            {

                string cmdstring = string.Format("Select * from {0} orderby {1}",
                                             Common.Data.News.TableName,
                                             orderbye);

                cmd.CommandText = cmdstring;
                cmd.Connection = this.GetConnection();
                cmd.Connection.Open();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    News = new Common.Data.News();

                    News.news_id = int.Parse(reader[Common.Data.News.Newsid_filed].ToString());
                    News.news_Sub = reader[Common.Data.News.news_Sub_filed].ToString();
                    News.news_full = reader[Common.Data.News.news_full_field].ToString();
                    
                }
            }
            return News;
        }
//--------------------------------------------------------------------------------------------------------
        public bool Insert_News(Common.Data.News news)
        {
            
            using (SqlCommand cmd = new SqlCommand())
            {
                string text = string.Format("insert into {0} ({1}, {2}, {3}) values (@{1}, @{2}, @{3})"
                                            , Common.Data.News.TableName
                                            , Common.Data.News.news_Sub_filed
                                            , Common.Data.News.news_full_field
                                            ,Common.Data.News.date_field        
                                            );
                cmd.CommandText = text;

                AddParameters(cmd, news);

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
//----------------------------------------------------------------------------------------------------
        private void AddParameters(SqlCommand cmd, Common.Data.News news)
        {

            SqlParameter param = new SqlParameter("@" + Common.Data.News.news_full_field, news.news_full);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@" + Common.Data.News.news_Sub_filed, news.news_Sub);
            param.SqlDbType = SqlDbType.NVarChar;
            cmd.Parameters.Add(param);


            param = new SqlParameter("@" + Common.Data.News.date_field, new Common.Utility().Set_Shamsi_Date());
            param.SqlDbType = SqlDbType.Date;
            cmd.Parameters.Add(param);

        }
    }
}
