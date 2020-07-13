using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaEfektow
    {
        public List<WidokEfekt> Efekty { get; set; } = new List<WidokEfekt>();
        public Przedmiot Przedmiot { get; set; }
        public ListaEfektow(sbyte id)
        {
            var tmpEfekty = RepoEfekty.PobierzWszystkieEfekty();
            var tmp = RepoPrzedmioty.PobierzPrzedmiot(id);
            if (tmp != null)
                this.Przedmiot = tmp;
            foreach (var e in tmpEfekty)
                Efekty.Add(new WidokEfekt(e.Opis));
        }
    }
}
