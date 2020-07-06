using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL
{
    class DBConnection
    {
        private MySqlConnection cnn;
        private static DBConnection connection;
        private DBConnection()
        {
            String connetionString = $"host={dbData.HOST};port={dbData.PORT};user id={dbData.USER};password={dbData.PASSWORD};database={dbData.DB};";
            cnn = new MySqlConnection(@connetionString);
            cnn.Open();
        }
        public static DBConnection Connection
        {
            get
            {
                if (connection == null)
                    connection = new DBConnection();
                return connection;
            }
        }
    }
}
