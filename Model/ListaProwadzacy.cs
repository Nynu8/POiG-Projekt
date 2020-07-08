using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaProwadzacy
    {
        public List<Prowadzacy> Prowadzacy { get; set; } = new List<Prowadzacy>();
        public ListaProwadzacy()
        {
            var prowadzacy = RepoProwadzacy.PobierzWszystkichProwadzacych();
            foreach (var p in prowadzacy)
            {
                this.Prowadzacy.Add(p);
            }
        }
    }
}
