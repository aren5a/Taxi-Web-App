using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.BLL
{
  public  class NewsBLL
    {
      public bool Submit_News (Common.Data.News news)
      {
          validate(news);
          DAL.NewsDAL newsDAL = new DAL.NewsDAL();
          return newsDAL.Insert_News(news);

    
      }
      private void validate(Common.Data.News news) 
      {
          if ( string.IsNullOrEmpty(news.news_Sub) && string.IsNullOrEmpty(news.news_Sub))
              throw new Common.GeneralException (Common.TaxiResource.News_Submit_Err);
      }
    }
}
