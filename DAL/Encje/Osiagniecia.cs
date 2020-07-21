using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Osiagniecia
    {
        public sbyte Id_osiagniecia { get; set; }
        public sbyte Id_prowadzacy { get; set; }
        public sbyte Id_student { get; set; }
        public string Opis { get; set; }
        public string Data { get; set; }
        public string Rodzaj { get; set; }
        public sbyte Punkty { get; set; }
        public Osiagniecia(MySqlDataReader reader)
        {
            Id_osiagniecia = sbyte.Parse(reader["id_osiagniecia"].ToString());
            Id_student = sbyte.Parse(reader["id_student"].ToString());
            Id_prowadzacy = sbyte.Parse(reader["id_prowadzacy"].ToString());
            Opis = reader["opis"].ToString();
            Data = reader["data"].ToString();
            Rodzaj = reader["punkty"].ToString();
            Punkty = sbyte.Parse(reader["punkty"].ToString());
        }
        public override bool Equals(object obj)
        {
            var osiagniecia = obj as Osiagniecia;
            if (osiagniecia is null) return false;
            if (Id_prowadzacy != osiagniecia.Id_prowadzacy) return false;
            if (Id_student != osiagniecia.Id_student) return false;
            if (Opis.ToLower() != osiagniecia.Opis.ToLower()) return false;
            if (Data.ToLower() != osiagniecia.Data.ToLower()) return false;
            if (Rodzaj.ToLower() != osiagniecia.Rodzaj.ToLower()) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
