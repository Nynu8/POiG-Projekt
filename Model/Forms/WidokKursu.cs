using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokKursu
    {
        public sbyte ID { get; set; }
        public string Przedmiot { get; set; }
        public string Grupa { get; set; }
        public sbyte Rok { get; set; }
        public List<Student> Uczestnicy { get; set; }

        public WidokKursu(sbyte id_kursu, string przedmiot, string grupa, sbyte rok, List<Student> uczestnicy)
        {
            ID = id_kursu;
            Przedmiot = przedmiot;
            Grupa = grupa;
            Rok = rok;
            Uczestnicy = uczestnicy;
        }
    }
}
