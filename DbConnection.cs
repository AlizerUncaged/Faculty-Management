using System.Data.SqlClient;

namespace Group3Proj
{
    public static class DbConnection
    {
        private static SqlConnection _sqlConnection = null;

        public static SqlConnection Connection
        {
            get
            {
                if (_sqlConnection is null)
                {
                    _sqlConnection = new SqlConnection(
                        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf");

                    _sqlConnection.Open();
                }

                return _sqlConnection;
            }
        }
    }
}