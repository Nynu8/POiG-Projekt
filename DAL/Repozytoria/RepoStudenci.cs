using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoStudenci
    {
        private const string wszyscy_studenci = "SELECT * FROM student";

        public static List<Student> PobierzWszyscyStudenci()
        {
            List<Student> studenci = new List<Student>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszyscy_studenci, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    studenci.Add(new Student(reader));
                connection.Close();
            }
            return studenci;
        }
    }
}
