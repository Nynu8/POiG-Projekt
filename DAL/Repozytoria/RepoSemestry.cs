using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoSemestry
    {
        private const string wszystkie = "SELECT * FROM semestr";

        public static List<Semestr> PobierzWszystkieSemestry()
        {
            List<Semestr> semestry = new List<Semestr>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    semestry.Add(new Semestr(reader));
                connection.Close();
            }
            return semestry;
        }
    }
}
