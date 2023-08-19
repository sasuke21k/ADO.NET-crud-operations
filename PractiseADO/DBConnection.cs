using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace PractiseADO
{
   public  class DBConnection
    {

       public SqlConnection GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            return new SqlConnection(connection);
        }

    }
}
