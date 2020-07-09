using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaPrzedmiotow
    {
        public List<WidokPrzedmiotu> Przedmioty { get; set; } = new List<WidokPrzedmiotu>();
        public ListaPrzedmiotow()
        {
            var przedmioty = RepoPrzedmioty.PobierzWszystkiePrzedmioty();
            foreach (var p in przedmioty)
            {
                Przedmioty.Add(new WidokPrzedmiotu(p));
            }
        }
    }
}
