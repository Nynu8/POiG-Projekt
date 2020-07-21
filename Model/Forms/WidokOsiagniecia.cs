using System;
using System.Collections.Generic;
using System.Text;
using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;

namespace POiG_Projekt.Model.Forms
{
    class WidokOsiagniecia
    {
        public string Opis { get; set; }
        public string Data { get; set; }
        public string Rodzaj { get; set; }
        public sbyte Punkty { get; set; }
        public string Prowadzacy { get; set; }

        public WidokOsiagniecia(Osiagniecia o)
        {
            Opis = o.Opis;
            Data = o.Data;
            Rodzaj = o.Rodzaj;
            Punkty = o.Punkty;
            Prowadzacy = RepoProwadzacy.PobierzProwadzacegoOId(o.Id_prowadzacy).ToString();
        }
    }
}
