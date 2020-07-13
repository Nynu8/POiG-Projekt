using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokKursu
    {
        public string Przedmiot { get; set; }
        public string Grupa { get; set; }
        public sbyte Rok { get; set; }
        public List<Student> Uczestnicy { get; set; }

        public WidokKursu(string przedmiot, string grupa, sbyte rok, List<Student> uczestnicy)
        {
            Przedmiot = przedmiot;
            Grupa = grupa;
            Rok = rok;
            Uczestnicy = uczestnicy;
        }
    }
}
