using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        static string server = Context.Database.Connection.DataSource;
        static string database = Context.Database.Connection.Database;
        static string login = "meckb";
        static string password = "j9q7du6b";

        public static void NewConnectionString()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = server;
            sqlConnection.InitialCatalog = database;
            sqlConnection.UserID = login;
            sqlConnection.Password = password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
        }

        private Core() { }
    }
}
