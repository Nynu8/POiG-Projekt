using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.Model
{
    class ListaStudentow
    {
        public List<Student> Studenci { get; set; } = new List<Student>();
        public ListaStudentow()
        {
            var studenci = RepoStudenci.PobierzWszyscyStudenci();
            foreach (var p in studenci)
            {
                this.Studenci.Add(p);
            }
        }
    }
}
