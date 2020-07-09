﻿using POiG_Projekt.DAL.Encje;
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
        public List<Semestr> Semestry { get; set; } = new List<Semestr>();
        public List<Grupa> Grupy { get; set; } = new List<Grupa>();
        public ListaStudentow()
        {
            var studenci = RepoStudenci.PobierzWszyscyStudenci();
            foreach (var p in studenci)
            {
                this.Studenci.Add(p);
            }

            var semestry = RepoSemestry.PobierzWszystkieSemestry();
            foreach (var p in semestry)
            {
                this.Semestry.Add(p);
            }

            var grupy = RepoGrupy.PobierzWszystkieGrupy();
            foreach (var p in grupy)
            {
                this.Grupy.Add(p);
            }
        }

        public List<Student> PobierzWybranychStudentow(sbyte idGrupy)
        {
            return Studenci.Where(a => a.IdGrupy == idGrupy).ToList();
        }
    }
}
