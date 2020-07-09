using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaKursow
    {
        List<Kurs> kursy = new List<Kurs>();
        public List<WidokKursu> Kursy { get; set; } = new List<WidokKursu>();
        public ListaKursow()
        {
            var mojekursy = RepoKursy.PobierzWszystkieMojeKursy();
            var przedmioty = RepoPrzedmioty.PobierzWszystkiePrzedmioty();
            var grupy = RepoGrupy.PobierzWszystkieGrupy();
            var semestry = RepoSemestry.PobierzWszystkieSemestry();
            var studenci = RepoStudenci.PobierzWszyscyStudenci();
            foreach (var p in mojekursy)
            {
                var przedmiot = przedmioty.Where(P => P.Id_przedmiot == p.Id_przedmiot).Last();
                var semestr = semestry.Where(s => s.Id_semestr == p.Id_semestr).Last(); 
                var grupay = grupy.Where(g => g.Id_kurs == p.Id_kurs).ToList();
                foreach (var g in grupay)
                    Kursy.Add(new WidokKursu(przedmiot.Nazwa, g.Nazwa, semestr.Rok, studenci.Where(s => s.IdGrupy == g.Id_grupa).ToList()));
            }

        }
    }
}
