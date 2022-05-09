using System;
using System.Data.SqlClient;
using System.IO;
using CompService.Supporting;
using CompService.Models;

namespace CompService
{
    class Core
    {
        private static CompServiceEntities context;

        public static CompServiceEntities Context
        {
            get => context ?? (context = new CompServiceEntities());
        }
        public static string Server { get => server; set => server = value; }
        public static string Database { get => database; set => database = value; }
        public static string Login { get => login; set => login = value; }
        public static string Password { get => password; set => password = value; }

        static string server;
        static string database;
        static string login;
        static string password;
        static string connectionConfig = Environment.CurrentDirectory + @"/config";

        public static void LoadConnectionData()
        {
            if (File.Exists(connectionConfig))
            {
                var connectionData = ConnectionСryptography.Decrypt(File.ReadAllText(connectionConfig)).Split(';');
                server = connectionData[0];
                database = connectionData[1];
                login = connectionData[2];
                password = connectionData[3];
                NewConnectionString();
            }
        }

        public static void NewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = server;
            sqlConnection.InitialCatalog = database;
            sqlConnection.UserID = login;
            sqlConnection.Password = password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
            SaveConnectionData();
        }

        public static void SaveConnectionData()
        {
            File.WriteAllText(connectionConfig, ConnectionСryptography.Encrypt($"{server};{database};{login};{password}"));
        }
    }
}
