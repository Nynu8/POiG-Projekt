using MySql.Data.MySqlClient;
using POiG_Projekt.DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace POiG_Projekt.Model
{
    class Logowanie
    {
        public static string GenerateSaltedHash(string password, string salt)
        {
            try
            {
                HashAlgorithm algorithm = new SHA256Managed();

                byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
                byte[] saltBytes = Encoding.Unicode.GetBytes(salt);

                byte[] passwordWithSaltBytes = new byte[passwordBytes.Length + saltBytes.Length];
                saltBytes.CopyTo(passwordWithSaltBytes, 0);
                passwordBytes.CopyTo(passwordWithSaltBytes, saltBytes.Length);

                byte[] hash = algorithm.ComputeHash(passwordWithSaltBytes);
                return Convert.ToBase64String(hash);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public static uint GetID(string username, string password)
        {
            var hashedPassword = GenerateSaltedHash(password, username);
            string loginQuery = $"SELECT id_uzytkownik FROM uzytkownik WHERE login = '{username}' AND haslo = '{hashedPassword}';";
            uint id = 0;
            var tmp = DBConnection.Connection;
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(loginQuery, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    id = uint.Parse(reader["id_uzytkownik"].ToString());
                connection.Close();
            }
            return id;
        }
    }
}
