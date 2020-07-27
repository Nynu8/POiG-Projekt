using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaEfektow
    {
        public static List<WidokEfekt> OpisyEfektow(sbyte id)
        {
            List<WidokEfekt> Efekty = new List<WidokEfekt>();
            var tmpEfekty = RepoEfekty.PobierzWszystkieEfekty();
            foreach (var e in tmpEfekty)
                if(e.Id_przedmiot == id)
                    Efekty.Add(new WidokEfekt(e.Opis));
            return Efekty;
        }
    }
}
