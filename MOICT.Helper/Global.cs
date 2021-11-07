
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MOICT.Helper
{
    public class Global
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); }
        }
        public static string ConnectionString2
        {
            get { return ConfigurationManager.ConnectionStrings["ConnectionString2"].ToString(); }
        }
    }

}
