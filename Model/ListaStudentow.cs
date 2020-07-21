using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POiG_Projekt.Model.Forms;

namespace POiG_Projekt.Model
{
    class ListaStudentow
    {
        public List<WidokStudenta> Studenci { get; set; } = new List<WidokStudenta>();
        public List<int> Rok { get; set; } = new List<int>();
        public List<Grupa> Grupy { get; set; } = new List<Grupa>();
        public ListaStudentow()
        {
            var studenci = RepoStudenci.PobierzWszyscyStudenci();
            foreach (var p in studenci)
            {
                this.Studenci.Add(new WidokStudenta(p));
            }

            var grupy = RepoGrupy.PobierzWszystkieGrupy();
            foreach (var p in grupy)
            {
                this.Grupy.Add(p);
            }

            foreach (var p in grupy)
            {
                if(!this.Rok.Contains(p.Rok))
                    this.Rok.Add(p.Rok);
            }
        }

        public List<WidokStudenta> PobierzWybranychStudentow(sbyte idGrupy)
        {
            return Studenci.Where(a => a.Grupa.Id_grupa == idGrupy).ToList();
        }
        public List<WidokStudenta> PobierzWybranychStudentowRok(int rok)
        {
            return Studenci.Where(a => a.Grupa.Rok == rok).ToList();
        }
        public List<Grupa> PobierzWybraneGrupy(int rok)
        {
            return Grupy.Where(g=>g.Rok==rok).ToList();
        }
    }
}
