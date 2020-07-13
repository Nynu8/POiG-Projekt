using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Kurs
    {
        private sbyte idSemestru;

        public sbyte Id_kurs { get; set; }
        public sbyte Id_przedmiot { get; set; }
        public sbyte Id_prowadzacy { get; set; }
        public sbyte Id_semestr { get; set; }
        public override bool Equals(object obj)
        {
            var kurs = obj as Kurs;
            if (kurs is null) return false;
            if (Id_przedmiot != kurs.Id_przedmiot) return false;
            if (Id_prowadzacy != kurs.Id_prowadzacy) return false;
            if (Id_semestr != kurs.Id_semestr) return false;
            return true;
        }
        public Kurs(MySqlDataReader reader)
        {
            Id_kurs = sbyte.Parse(reader["id_kurs"].ToString());
            Id_przedmiot = sbyte.Parse(reader["Id_przedmiot"].ToString());
            Id_prowadzacy = sbyte.Parse(reader["Id_prowadzacy"].ToString());
            Id_semestr = sbyte.Parse(reader["Id_semestr"].ToString());
        }

        public Kurs(sbyte idSemestru)
        {
            this.idSemestru = idSemestru;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
