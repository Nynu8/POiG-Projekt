using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Semestr
    {
        public sbyte Id_semestr { get; set; }
        public string Rodzaj { get; set; }
        public sbyte Rok { get; set; }
        public bool Aktywny { get; set; }
        public override bool Equals(object obj)
        {
            var semestr = obj as Semestr;
            if (semestr is null) return false;
            if (Rodzaj.ToLower() != semestr.Rodzaj.ToLower()) return false;
            if (Rok != semestr.Rok) return false;
            if (Aktywny && (!semestr.Aktywny)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
