using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLib
{
    public class Connection
    {
        public static SQLServerConnection ReturnSqlServerConnection()
        {
            string server = ConfigurationManager.AppSettings["SQLServer"];
            string database = ConfigurationManager.AppSettings["SQLServerDB"];
            string userId = ConfigurationManager.AppSettings["SQLServerUsr"];
            string passWord = ConfigurationManager.AppSettings["SQLServerPwd"];

            SQLServerConnection connection = new SQLServerConnection { Database = database, PassWord = passWord, Server = server, UserId = userId };

            return connection;
        }
    }


    public class SQLServerConnection
    {

        public string Database { get; set; }
        public string PassWord { get; set; }
        public string Server { get; set; }
        public string UserId { get; set; }
    }
}

