using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Ocena
    {
        public sbyte Id_ocena { get; set; }
        public sbyte Id_student { get; set; }
        public sbyte Id_kurs { get; set; }
        public string Opis { get; set; }
        public sbyte Wartosc { get; set; }

        public Ocena(MySqlDataReader reader)
        {
            Id_ocena = sbyte.Parse(reader["id_ocena"].ToString());
            Id_student = sbyte.Parse(reader["id_student"].ToString());
            Id_kurs = sbyte.Parse(reader["id_kurs"].ToString());
            Opis = reader["opis"].ToString();
            Wartosc = sbyte.Parse(reader["wartosc"].ToString());
        }
        public override bool Equals(object obj)
        {
            var ocena = obj as Ocena;
            if (ocena is null) return false;
            if (Opis.ToLower() != ocena.Opis.ToLower()) return false;
            if (Wartosc != ocena.Wartosc) return false;
            if (Id_student != ocena.Id_student) return false;
            if (Id_kurs != ocena.Id_kurs) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
