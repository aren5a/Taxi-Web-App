using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Taxi.DAL
{
    public abstract class DALBase
    {
        protected static string ConnectionString = ConfigurationManager.ConnectionStrings["TaxiService"].ConnectionString;

        protected SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString;
            return cn;
        }

    }
}
    

