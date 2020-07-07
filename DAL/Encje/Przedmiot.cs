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
        public override bool Equals(object obj)
        {
            var przedmiot = obj as Przedmiot;
            if (przedmiot is null) return false;
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
