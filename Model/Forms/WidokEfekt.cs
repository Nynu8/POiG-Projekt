using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokEfekt
    {
        public string Opis { get; set; }

        public WidokEfekt(string opis)
        {
            Opis = opis;
        }
    }
}
