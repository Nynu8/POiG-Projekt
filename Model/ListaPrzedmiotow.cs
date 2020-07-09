using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaPrzedmiotow
    {
        public List<Przedmiot> Przedmioty { get; set; } = new List<Przedmiot>();
        public ListaPrzedmiotow()
        {
            var przedmioty = RepoPrzedmioty.PobierzWszystkiePrzedmioty();
            foreach (var p in przedmioty)
            {
                this.Przedmioty.Add(p);
            }
        }
    }
}
