using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.DAL.Encje
{
    class Uzytkownik
    {
        public sbyte Id_uzytkownik { get; set; }
        public sbyte Id_prowadzacy { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public bool Aktywne { get; set; }
        public override bool Equals(object obj)
        {
            var uzytkownik = obj as Uzytkownik;
            if (uzytkownik is null) return false;
            if (Id_prowadzacy != uzytkownik.Id_prowadzacy) return false;
            if (Login.ToLower() != uzytkownik.Login.ToLower()) return false;
            if (Haslo.ToLower() != uzytkownik.Haslo.ToLower()) return false;
            if (Aktywne && (!uzytkownik.Aktywne)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
