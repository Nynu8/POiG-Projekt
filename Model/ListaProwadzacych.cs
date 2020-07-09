using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaProwadzacych
    {
        public List<Prowadzacy> Prowadzacy { get; set; } = new List<Prowadzacy>();
        public ListaProwadzacych()
        {
            var prowadzacy = RepoProwadzacy.PobierzWszystkichProwadzacych();
            foreach (var p in prowadzacy)
            {
                this.Prowadzacy.Add(p);
            }
        }

        public string PobierzBiezacegoUzytkownika(uint ID)
        {
            int i = 0;
            while (this.Prowadzacy[i].Id_prowadzacy != ID)
                i++;
            return $"{Prowadzacy[i].Imie} {Prowadzacy[i].Nazwisko}";
        }
    }
}
