using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokKursu
    {
        public string Przedmiot { get; set; }
        public string Grupa { get; set; }
        public sbyte Semestr { get; set; }
        public List<WidokStudenta> Uczestnicy { get; set; }
    }
}
