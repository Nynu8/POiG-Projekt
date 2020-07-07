using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Efekt
    {
        public sbyte Id_efekt { get; set; }
        public sbyte Id_przedmiot { get; set; }
        public string Opis { get; set; }
        public override bool Equals(object obj)
        {
            var efekt = obj as Efekt;
            if (efekt is null) return false;
            if (Opis.ToLower() != efekt.Opis.ToLower()) return false;
            if (Id_przedmiot != efekt.Id_przedmiot) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
