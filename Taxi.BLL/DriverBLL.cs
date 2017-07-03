using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;


namespace Taxi.BLL
{
    public class DriverBLL
    {

        public IList<Common.Data.Driver> Update_Position()
        {
            return new DAL.DriverDAL().Update_Position();
        }
        public DataSet GetDriverView( string filter)
        {
            return new DAL.DriverDAL().GetDriverView(filter);
        }

        public IList<Common.Data.Driver> Get_All()
        {
            return new DAL.DriverDAL().Get_All();
        }

        public bool DeleteDriver(int driverId)
        {
            return new DAL.DriverDAL().DeleteDriver(driverId); 
        }

        public bool Update_Activate(int driverId)
        {
            return new DAL.DriverDAL().Update_Activate(driverId);
        }

        //public bool Update_Position(Common.Data.Driver driver)
        //{
        //    return new DAL.DriverDAL().Update_Position(driver);
        //}

        public bool InsertDriver(Common.Data.Driver driver)
        {
            if (driver != null && ValidateDriver(driver))
            {
                return new DAL.DriverDAL().insertDriver(driver);
            }
            return false;
        }
        
        public bool ValidateDriver(Common.Data.Driver driver)
        {
            bool validated = true;
            if (!Regex.IsMatch(driver.email, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") && !Regex.IsMatch(driver.tell_num, @"\d{8}"))
            {
                validated = false;
            }

            if (string.IsNullOrEmpty(driver.Name) & string.IsNullOrEmpty(driver.L_name) & string.IsNullOrEmpty(driver.tell_num) & string.IsNullOrEmpty(driver.address))
            {
                validated = false;
            }
            return validated;
        }
    }
}
