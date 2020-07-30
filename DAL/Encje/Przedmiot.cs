using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Przedmiot
    {
        public sbyte Id_przedmiot { get; set; }
        public string Nazwa { get; set; }
        public string Skrot { get; set; }
        public string Rodzaj { get; set; }
        public sbyte ECTS { get; set; }
        public Przedmiot(MySqlDataReader reader)
        {
            Id_przedmiot = sbyte.Parse(reader["id_przedmiot"].ToString());
            Nazwa = reader["nazwa"].ToString();
            Skrot = reader["skrot"].ToString();
            Rodzaj = reader["zaliczenie"].ToString();
            ECTS = sbyte.Parse(reader["ECTS"].ToString());
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Przedmiot przedmiot)) return false;
            if (Nazwa.ToLower() != przedmiot.Nazwa.ToLower()) return false;
            if (Skrot.ToLower() != przedmiot.Skrot.ToLower()) return false;
            if (Rodzaj.ToLower() != przedmiot.Rodzaj.ToLower()) return false;
            if (ECTS != przedmiot.ECTS) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
