using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Student
    {
        public sbyte? Id_student { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NrAlbumu { get; set; }
        public bool Stypendium { get; set; }
        public sbyte Punkty { get; set; }
        public string DataRozpoczecia { get; set; }
        public double? Srednia { get; set; }
        public string Email { get; set; }
        public sbyte IdGrupy { get; set; }

        public Student(string imie, string nazwisko, string nrAlbumu, bool stypendium, sbyte punkty, string dataRozpoczecia, double srednia, string email, sbyte idGrupy)
        {
            Id_student = null;
            Imie = imie;
            Nazwisko = nazwisko;
            NrAlbumu = nrAlbumu;
            Stypendium = stypendium;
            Punkty = punkty;
            DataRozpoczecia = dataRozpoczecia;
            Srednia = srednia;
            Email = email;
            IdGrupy = idGrupy;
        }

        public Student(MySqlDataReader reader)
        {
            Id_student = sbyte.Parse(reader["id_student"].ToString());
            Imie = reader["imie"].ToString();
            Nazwisko = reader["nazwisko"].ToString();
            NrAlbumu = reader["nrAlbumu"].ToString();
            Stypendium = bool.Parse(reader["stypendium"].ToString());
            Punkty = sbyte.Parse(reader["punkty"].ToString());
            DataRozpoczecia = reader["dataRozpoczecia"].ToString();
            double srednia;
            double.TryParse(reader["srednia"].ToString(), out srednia);
            Srednia = srednia;
            Email = reader["email"].ToString();
            IdGrupy = sbyte.Parse(reader["id_grupa"].ToString());
        }


        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, numer albumu {NrAlbumu}, {Email}";
        }
        public override bool Equals(object obj)
        {
            var osoba = obj as Student;
            if (osoba is null) return false;
            if (Imie.ToLower() != osoba.Imie.ToLower()) return false;
            if (Nazwisko.ToLower() != osoba.Nazwisko.ToLower()) return false;
            if (NrAlbumu != osoba.NrAlbumu) return false;
            if (!(Stypendium && osoba.Stypendium)) return false;
            if (Punkty != osoba.Punkty) return false;
            if (Nazwisko.ToLower() != osoba.Nazwisko.ToLower()) return false;
            if (DataRozpoczecia.ToLower() != osoba.DataRozpoczecia.ToLower()) return false;
            if (Srednia != osoba.Srednia) return false;
            if (Email.ToLower() != osoba.Email.ToLower()) return false;
            if (IdGrupy != osoba.IdGrupy) return false;
            return true;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
