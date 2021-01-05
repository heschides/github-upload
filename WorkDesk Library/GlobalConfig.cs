using Microsoft.Azure.Management.AppService.Fluent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Connections;
using SqlConnection = WorkDesk_Library.Connections.SqlConnection;

namespace WorkDesk_Library
{

    //Determine location to save data.  InitializeConnection function used in Program.cs
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(string connectionType)
        {
            if (connectionType == "database")    
            {
                SqlConnection sql = new SqlConnection();
                Connection = sql;
            }
            else if (connectionType == "textfiles")
            {
                TextConnection text = new TextConnection();
                Connection = text;
            }

        }
        //Return the connection string from App.config.  I'll use this function on SqlConnection.CS
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
