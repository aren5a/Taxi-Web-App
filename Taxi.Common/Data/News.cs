using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common.Data
{
   public class News
    {
        public const string TableName = "News_Tbl";

        public const string Newsid_filed = "news_id";
        public const string news_Sub_filed = "news_Sub";
        public const string news_full_field = "news_full";
        public const string date_field = "Date";

        private int _news_id;
        public int news_id
        {
            get { return _news_id; }
            set { _news_id = value; }
        }
        private string _news_Sub;
        public string news_Sub
        {
            get { return _news_Sub; }
            set { _news_Sub = value; }
        }
        private string _news_full;
        public string news_full
        {
            get { return _news_full; }
            set { _news_full = value; }
        }
        private string _Date;
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
    }
}
