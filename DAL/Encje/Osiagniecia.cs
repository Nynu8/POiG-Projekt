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
