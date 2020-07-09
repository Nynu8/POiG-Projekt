﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using POiG_Projekt.DAL.Encje;

namespace POiG_Projekt.DAL.Repozytoria
{
    class RepoEfekty
    {
        private const string wszystkie_efekty = "SELECT * FROM efekt";
        

        public static List<Efekt> PobierzWszystkieEfekty()
        {
            List<Efekt> efekty = new List<Efekt>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(wszystkie_efekty, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    efekty.Add(new Efekt(reader));
                connection.Close();
            }
            return efekty;
        }

        public static List<Efekt> PobierzEfektyPrzedmiotu(sbyte ID)
        {
            string efekty_z_przedmiotu = $"SELECT * FROM efekt where id_przedmiot={ID};";//nie wiem jak to wrzucić jako stałą
            List<Efekt> efekty = new List<Efekt>();
            using (var connection = DBConnection.Cnn)
            {
                MySqlCommand command = new MySqlCommand(efekty_z_przedmiotu, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    efekty.Add(new Efekt(reader));
                connection.Close();
            }
            return efekty;
        }
    }
}
