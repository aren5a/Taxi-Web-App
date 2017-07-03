using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using AspMap;
using AspMap.Web;
using System.ComponentModel;
using System.Data;
using System.Globalization; 


namespace Taxi.Common
{
    public class Utility
    {
        public const string CurrentUserSession = "CurrentUser";

        public bool username_exists(ArrayList userList, string username)
        {
            username = username.Trim();
            if (string.IsNullOrEmpty(username) )
            {
                return true;
            }
                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].ToString().ToLower() == username.ToLower())
                    {
                        return true;
                    }
                }          
            return false;
        }

        public Common.Data.Driver Find_Driver(IList<Common.Data.Driver> driverList, AspMap.Point point)
        {
    
            //Calculate Distance Formula is: ((Xb-Xa)^2+(Yb-Ya)^2)^(1/2)
            
            Common.Data.Driver closest_driver = new Data.Driver();
            double test2 = Math.Pow((1186 - 2154) , 2);
            double test1 = (-2736+1316)^2;
            double test3= test2 + test1;
            double test = Math.Sqrt(test3);
            double minDistance = Math.Abs(Math.Sqrt(Math.Pow(driverList[0].pos_x - point.X, 2) + Math.Pow(driverList[0].pos_y - point.Y, 2))); closest_driver = driverList[0];
            double temp;
            for (int i = 1; i < driverList.Count; i++)
            {
                temp = Math.Abs(Math.Sqrt(Math.Pow(driverList[i].pos_x - point.X, 2) + Math.Pow(driverList[i].pos_y - point.Y, 2)));
                if (Math.Abs(temp) < minDistance) { minDistance =Math.Abs(temp); closest_driver = driverList[i]; }
            }
            return closest_driver;
        }

        public DateTime Set_Shamsi_Date()
        {
            PersianCalendar pc = new PersianCalendar();

            string Year, Day, Month;
            Year = pc.GetYear(DateTime.Now).ToString();
            Month = pc.GetMonth(DateTime.Now).ToString();
            Day = pc.GetDayOfMonth(DateTime.Now).ToString();

            if (Day.Length == 1)
                Day = pc.GetDayOfMonth(DateTime.Now).ToString().Insert(0, "0");

            if (Month.Length == 1)
                Month = pc.GetMonth(DateTime.Now).ToString().Insert(0, "0");

            CultureInfo CultureInfoDateCulture = new CultureInfo("fa-IR");
            return DateTime.ParseExact((Year + "/" + Month + "/" + Day), "yyyy/MM/dd", CultureInfoDateCulture);
        }

    }
}
