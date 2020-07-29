using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoGrupy
    {
        private const string wszystkie = "SELECT * FROM grupa";
        private const string grupa_studenta = "SELECT * FROM grupa WHERE id_grupa=";

        public static List<Grupa> PobierzWszystkieGrupy()
        {
            List<Grupa> grupy = new List<Grupa>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    grupy.Add(new Grupa(reader));
                connection.Close();
            }
            return grupy;
        }

        public static Grupa PobierzGrupeOId(sbyte id)
        {
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(grupa_studenta+id, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    return new Grupa(reader);
                connection.Close();
            }

            return null;
        }
    }
}
