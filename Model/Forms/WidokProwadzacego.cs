using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokProwadzacego
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Tytul { get; set; }
        public string Email { get; set; }
        //to mozna tez dac widok przedmiotu ale to bez roznicy bo potrzebujemy tylko skrotow nazw
        //całe nazwy będą raczej za długie xd
        private List<Przedmiot> przedmioty;
        public string Przedmioty
        {
            get
            {
                return this.ListaPrzedmiotow();
            }
        }

        public WidokProwadzacego(Prowadzacy p)
        {
            this.Imie = p.Imie;
            this.Nazwisko = p.Nazwisko;
            this.Tytul = p.Tytul;
            this.Email = p.Email;
            this.przedmioty = RepoPrzedmioty.PobierzPrzedmiotyProwadzacego(p.Id_prowadzacy);
        }

        public override string ToString()
        {
            return $"{this.Imie} {this.Nazwisko}";
        }

        public string ListaPrzedmiotow()
        {
            string skroty = "";
            foreach (Przedmiot p in this.przedmioty)
                skroty += p.Skrot+" ";
            return skroty;
        }
    }
}
