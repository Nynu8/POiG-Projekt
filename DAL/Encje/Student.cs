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
        public sbyte NrAlbumu { get; set; }
        public bool Stypendium { get; set; }
        public sbyte Punkty { get; set; }
        public string DataRozpoczecia { get; set; }
        public string Srednia { get; set; }
        public string Email { get; set; }
        public sbyte IdOceny { get; set; }
        public sbyte IdGrupy { get; set; }
        public sbyte IdOsiagniecia { get; set; }

        public Student(string imie, string nazwisko, sbyte nrAlbumu, bool stypendium, sbyte punkty, string dataRozpoczecia, string srednia, string email, sbyte idOceny, sbyte idGrupy, sbyte idOsiagniecia)
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
            IdOceny = idOceny;
            IdGrupy = idGrupy;
            IdOsiagniecia = idOsiagniecia;
        }

        public Student(MySqlDataReader reader)
        {
            //Id_student = sbyte.Parse(reader["id_s"].ToString());
            //Imie = reader["imie"].ToString();
            //Nazwisko = reader["nazwisko"].ToString();
            //NrAlbumu = sbyte.Parse(reader["nrAlbumu"].ToString());
            //Stypendium =bool.Parse(reader["stypendium"].ToString());
            //Punkty = sbyte.Parse(reader["punkty"].ToString());
            //DataRozpoczecia = reader["dataRozpoczecia"].ToString();
            //Srednia = sbyte.Parse(reader["srednia"].ToString());
            //Email = reader["email"].ToString();
            //IdOceny = sbyte.Parse(reader["id_oceny"].ToString());
            //IdGrupy = sbyte.Parse(reader["id_g"].ToString());
            //IdOsiagniecia = sbyte.Parse(reader["id_osiagniecia"].ToString());
        }


        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, numer albumu {NrAlbumu}";
        }

        //public string ToInsert()
        //{
        //    return $"('{Imie}', '{Nazwisko}', {NrAlbumu},'{Stypendium}','{Punkty}','{DataRozpoczecia}','{Srednia}','{Email}','{IdOceny}','{IdGrupy}','{IdOsiagniecia}')";
        //}
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
            if (Srednia.ToLower() != osoba.Srednia.ToLower()) return false;
            if (Email.ToLower() != osoba.Email.ToLower()) return false;
            if (IdOceny != osoba.IdOceny) return false;
            if (IdGrupy != osoba.IdGrupy) return false;
            if (IdOsiagniecia != osoba.IdOsiagniecia) return false;
            return true;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
