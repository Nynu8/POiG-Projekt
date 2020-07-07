using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Prowadzacy
    {
        public sbyte Id_prowadzacy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Tytul { get; set; }
        public string Email { get; set; }
        public Prowadzacy(MySqlDataReader reader)
        {
            Id_prowadzacy = sbyte.Parse(reader["id_prowadzacy"].ToString());
            Imie = reader["imie"].ToString();
            Nazwisko = reader["nazwisko"].ToString();
            Tytul = reader["tytul"].ToString();
            Email = reader["email"].ToString();
        }
        public override bool Equals(object obj)
        {
            var prowadzacy = obj as Prowadzacy;
            if (prowadzacy is null) return false;
            if (Imie.ToLower() != prowadzacy.Imie.ToLower()) return false;
            if (Nazwisko.ToLower() != prowadzacy.Nazwisko.ToLower()) return false;
            if (Tytul.ToLower() != prowadzacy.Tytul.ToLower()) return false;
            if (Email.ToLower() != prowadzacy.Email.ToLower()) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
