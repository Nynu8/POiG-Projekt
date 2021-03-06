﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL
{
    class DBConnection
    {
        public static MySqlConnection Cnn { get; set; }
        private static DBConnection connection;
        public static uint ID { get; set; }
        private DBConnection()
        {
            String connetionString = $"host={dbData.HOST};port={dbData.PORT};user id={dbData.USER};password={dbData.PASSWORD};database={dbData.DB};";
            Cnn = new MySqlConnection(@connetionString);
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
