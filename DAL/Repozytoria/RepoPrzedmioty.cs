using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoPrzedmioty
    {
        private const string wszystkie_przedmioty = "SELECT * FROM przedmiot";

        public static List<Przedmiot> PobierzWszystkiePrzedmioty()
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie_przedmioty, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    przedmioty.Add(new Przedmiot(reader));
                connection.Close();
            }
            return przedmioty;
        }
    }
}
