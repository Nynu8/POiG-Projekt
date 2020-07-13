using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokPrzedmiotu
    {
        public string Nazwa { get; set; }
        public string Skrot { get; set; }
        public string FormaZaliczenia { get; set; }
        public sbyte ECTS { get; set; }
        public int LiczbaEfektow { get; set; }
        public List<Efekt> Efekty { get; set; }
        public WidokPrzedmiotu(Przedmiot p)
        {
            this.Nazwa = p.Nazwa;
            this.Skrot = p.Skrot;
            this.FormaZaliczenia = p.Rodzaj;
            this.ECTS = p.ECTS;
            Efekty = RepoEfekty.PobierzEfektyPrzedmiotu(p.Id_przedmiot);
            this.LiczbaEfektow = Efekty.Count;
        }
    }
}
