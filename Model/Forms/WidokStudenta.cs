using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokStudenta
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public sbyte NrAlbumu { get; set; }
        public string Grupa { get; set; }
        public string DataRozpoczecia { get; set; }
        public List<Ocena> Oceny { get; set; }
        public List<WidokOsiagniecia> Osiagniecia { get; set; }
        public List<WidokPrzedmiotu> Przedmioty { get; set; }
    }
}
