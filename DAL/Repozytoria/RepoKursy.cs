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
        private const string moje_kursy = "SELECT * FROM kurs WHERE id_prowadzacy = ";
        private const string kurs_o_id = "SELECT * FROM kurs WHERE id_kurs = ";

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

        public static List<Kurs> PobierzWszystkieMojeKursy()
        {
            List<Kurs> kursy = new List<Kurs>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(moje_kursy + DBConnection.ID, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    kursy.Add(new Kurs(reader));
                connection.Close();
            }

            return kursy;
        }

        public static Kurs PobierzKursID(sbyte id)
        {
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(kurs_o_id + id, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    return new Kurs(reader);
                connection.Close();
            }

            return null;
        }
    }
}
