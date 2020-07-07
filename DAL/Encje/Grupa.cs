using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Grupa
    {
        public sbyte Id_grupa { get; set; }
        public sbyte Id_kurs { get; set; }
        public string Nazwa { get; set; }
        public override bool Equals(object obj)
        {
            var grupa = obj as Grupa;
            if (grupa is null) return false;
            if (Nazwa.ToLower() != grupa.Nazwa.ToLower()) return false;
            if (Id_kurs != grupa.Id_kurs) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
