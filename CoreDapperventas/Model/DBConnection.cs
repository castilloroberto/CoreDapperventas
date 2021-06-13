using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CoreDapperventas
{
    public class DBConnection
    {


        public static string GetRobertString()
        {
            return ConfigurationManager.ConnectionStrings["roberto"].ConnectionString;
        }

        public static string GetCarlosString()
        {
            return ConfigurationManager.ConnectionStrings["carlos"].ConnectionString;
        }

    }
}
