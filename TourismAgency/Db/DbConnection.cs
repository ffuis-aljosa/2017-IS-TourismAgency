using System.Data.SqlServerCe;

namespace TourismAgency.Db
{
    class DbConnection
    {
        private SqlCeConnection connection;

        private static DbConnection instance; 

        private DbConnection (string connectionString)
        {
            connection = new SqlCeConnection(connectionString);
            connection.Open(); 
        }

        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbConnection(@"Data Source=..\..\Database\Database.sdf");

                return instance;
            }
        }

        public SqlCeConnection Connection
        {
            get
            {
                return connection; 
            }
        }
    }
}
