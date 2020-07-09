using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaKursow
    {
        public List<Kurs> Kursy { get; set; } = new List<Kurs>();
        public ListaKursow()
        {
            var prowadzacy = RepoKursy.PobierzWszystkieMojeKursy();
            foreach (var p in prowadzacy)
            {
                this.Kursy.Add(p);
            }
        }
    }
}
