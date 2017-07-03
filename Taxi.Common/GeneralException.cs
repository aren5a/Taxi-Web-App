using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi.Common
{
   public class GeneralException:ApplicationException
    {
        public GeneralException(string message)
            : base(message)
        {
        }

        public GeneralException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
