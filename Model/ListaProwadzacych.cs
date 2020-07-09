using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaProwadzacych
    {
        public List<WidokProwadzacego> Prowadzacy { get; set; } = new List<WidokProwadzacego>();
        public ListaProwadzacych()
        {
            var prowadzacy = RepoProwadzacy.PobierzWszystkichProwadzacych();
            foreach (var p in prowadzacy)
            {
                this.Prowadzacy.Add(new WidokProwadzacego(p));
            }
        }

        public static string PobierzUzytkownika()
        {
            WidokProwadzacego w = new WidokProwadzacego(RepoProwadzacy.PobierzObecnegoUzytkownika());
            return w.ToString();
        }
    }
}
