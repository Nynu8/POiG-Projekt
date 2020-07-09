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
        private const string przedmioty_prowadzacego = "SELECT * FROM przedmiot JOIN kurs ON przedmiot.Id_przedmiot=kurs.Id_przedmiot where kurs.Id_prowadzacy = ";

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
        public static List<Przedmiot> PobierzPrzedmiotyProwadzacego(sbyte ID)
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(przedmioty_prowadzacego + ID, connection);
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
