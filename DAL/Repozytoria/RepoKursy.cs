using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoKursy
    {
        private const string wszystkie_kursy = "SELECT * FROM kurs";

        public static List<Kurs> PobierzWszystkieKursy()
        {
            List<Kurs> kursy = new List<Kurs>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie_kursy, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    kursy.Add(new Kurs(reader));
                connection.Close();
            }
            return kursy;
        }
    }
}
