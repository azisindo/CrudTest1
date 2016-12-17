using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace CrudTest1
{
    public class DbConnection
    {
        private MySqlConnection conn = null;
        private static DbConnection dbconn = null;
        //constructor
        private DbConnection()
        {
            if (conn==null)
            {
                //membaca data xml
                string server   = ConfigurationSettings.AppSettings["Server"];
                string database = ConfigurationSettings.AppSettings["Database"];

                string user      = "root";
                string password  = "password";
                string strConn   = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + user + ";PASSWORD=" + password;
                conn = new MySqlConnection(strConn);
                conn.Open();
            }
        }

        public static DbConnection GetInstance()
        {
            if (dbconn==null)
            {
                dbconn = new DbConnection();
            }
            return dbconn;
        }

        public MySqlConnection GetConnection()
        {
            return this.conn;

        }
    }
}
