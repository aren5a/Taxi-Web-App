using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Taxi.BLL
{
    public class ServiceBLL
    {
        public DataSet GetbyFilter(string filter, string orderby)
        {

            return new DAL.ServiceDAL().GetByFilter(filter, orderby);

        }
        public DataSet Get_All()
        {
            return new DAL.ServiceDAL().GrtAll();
        }
        public bool Insert(Common.Data.Service service)
        {
            if (service != null) return new DAL.ServiceDAL().Insert(service);
            return false;
        }

        public bool Update_User_Cost(int userID, decimal cost)
        {
            return new DAL.ServiceDAL().Update_User_Cost(userID, cost);
        }

        public bool Update_Cost(int serviceId, decimal cost)
        {
            if (serviceId != null & cost != null)
            {
                return new DAL.ServiceDAL().Update_Cost(serviceId, cost);
            }
            else return false;
        }
    }
}
