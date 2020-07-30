using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoOceny
    {
        private const string wszystkie = "SELECT * FROM ocena;";
        private const string oceny_studenta = "SELECT * FROM ocena WHERE id_student = ";

        public static List<Ocena> PobierzWszystkieOceny()
        {
            List<Ocena> oceny = new List<Ocena>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    oceny.Add(new Ocena(reader));
                connection.Close();
            }

            return oceny;
        }
        public static List<Ocena> PobierzOcenyStudenta(sbyte Id)
        {
            List<Ocena> oceny = new List<Ocena>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(oceny_studenta+Id, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    oceny.Add(new Ocena(reader));
                connection.Close();
            }

            return oceny;
        }

        public static void WprowadzOcene(sbyte id_kurs, sbyte id_studenta, string wartosc)
        {
            string del = $"DELETE FROM ocena WHERE id_kurs={id_kurs} AND id_student={id_studenta};";
            string ins = $"INSERT INTO ocena(id_student, id_kurs, wartosc) VALUES ({id_studenta}, {id_kurs}, {wartosc});";
            var connection = DBConnection.Cnn;
            connection.Open();
            MySqlCommand command1 = new MySqlCommand(del, connection);
            MySqlCommand command2 = new MySqlCommand(ins, connection);
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }
    }
}
