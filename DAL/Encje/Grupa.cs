using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Grupa
    {
        public Grupa(MySqlDataReader reader)
        {
            Id_grupa = sbyte.Parse(reader["id_grupa"].ToString());
            Id_kurs = sbyte.Parse(reader["id_kurs"].ToString());
            Nazwa = reader["nazwa"].ToString();
            Rok = sbyte.Parse(reader["rok"].ToString());
        }
        public sbyte Id_grupa { get; set; }
        public sbyte Id_kurs { get; set; }
        public string Nazwa { get; set; }
        public sbyte Rok { get; set; }
        public override bool Equals(object obj)
        {
            var grupa = obj as Grupa;
            if (grupa is null) return false;
            if (Nazwa.ToLower() != grupa.Nazwa.ToLower()) return false;
            if (Id_kurs != grupa.Id_kurs) return false;
            if (Rok != grupa.Rok) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{Nazwa}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
