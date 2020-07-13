using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaStudentow
    {
        public List<Student> Studenci { get; set; } = new List<Student>();
        public List<int> Rok { get; set; } = new List<int>();
        public List<Grupa> Grupy { get; set; } = new List<Grupa>();
        public ListaStudentow()
        {
            var studenci = RepoStudenci.PobierzWszyscyStudenci();
            foreach (var p in studenci)
            {
                this.Studenci.Add(p);
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

        public List<Student> PobierzWybranychStudentow(sbyte idGrupy)
        {
            return Studenci.Where(a => a.IdGrupy == idGrupy).ToList();
        }
        public List<Student> PobierzWybranychStudentowRok(int rok)
        {
            var tmp = Grupy.Where(g => g.Rok == rok).ToList();
            var studenci = new List<Student>();
            foreach (var g in tmp)
                foreach (var s in Studenci)
                    if (s.IdGrupy == g.Id_grupa)
                        studenci.Add(s);
            return studenci;
        }
        public List<Grupa> PobierzWybraneGrupy(int rok)
        {
            return Grupy.Where(g=>g.Rok==rok).ToList();
        }
    }
}
