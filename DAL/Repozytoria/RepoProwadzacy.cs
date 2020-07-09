using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoProwadzacy
    {
        private const string wszyscy_prowadzacy = "SELECT * FROM prowadzacy";
        private const string wybrany_prowadzacy = "SELECT * FROM prowadzacy WHERE id_prowadzacy = ";

        public static List<Prowadzacy> PobierzWszystkichProwadzacych()
        {
            List<Prowadzacy> prowadzacy = new List<Prowadzacy>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszyscy_prowadzacy, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    prowadzacy.Add(new Prowadzacy(reader));
                connection.Close();
            }
            return prowadzacy;
        }

        public static Prowadzacy PobierzObecnegoUzytkownika()
        {
            List<Prowadzacy> prowadzacy = new List<Prowadzacy>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wybrany_prowadzacy + DBConnection.ID, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    prowadzacy.Add(new Prowadzacy(reader));
                connection.Close();
            }
            return prowadzacy[0];
        }

    }
}
