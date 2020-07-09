using POiG_Projekt.DAL.Encje;
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
        public List<Przedmiot> Przedmioty { get; set; }
    }
}
