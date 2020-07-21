using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoOsiagniecia
    {
        private const string wszystkie = "SELECT * FROM osiagniecia";
        private const string osiagniecia_studenta = "SELECT * FROM osiagniecia WHERE id_student = ";

        public static List<Osiagniecia> PobierzWszystkieOsiagniecia()
        {
            List<Osiagniecia> osiagniecia = new List<Osiagniecia>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osiagniecia.Add(new Osiagniecia(reader));
                connection.Close();
            }
            return osiagniecia;
        }
        public static List<Osiagniecia> PobierzOsiagnieciaStudenta(sbyte Id)
        {
            List<Osiagniecia> osiagniecia = new List<Osiagniecia>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(osiagniecia_studenta+Id, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    osiagniecia.Add(new Osiagniecia(reader));
                connection.Close();
            }
            return osiagniecia;
        }
    }
}
