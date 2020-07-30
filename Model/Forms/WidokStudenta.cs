using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Text;
using POiG_Projekt.DAL.Repozytoria;
using System.Linq;

namespace POiG_Projekt.Model.Forms
{
    class WidokStudenta
    {
        public sbyte ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string NrAlbumu { get; set; }
        public string DataRozpoczecia { get; set; }
        public string Stypendium { get; set; }
        public double Srednia { get; set; }
        public double Punkty { get; set; }
        public Grupa Grupa { get; set; }
        public List<Ocena> Oceny { get; set; }
        public List<WidokOsiagniecia> Osiagniecia { get; set; }
        public List<WidokPrzedmiotu> Przedmioty { get; set; }

        public WidokStudenta(Student s)
        {
            this.ID = (sbyte)s.Id_student;
            this.Imie = s.Imie;
            this.Nazwisko = s.Nazwisko;
            this.Email = s.Email;
            this.NrAlbumu = s.NrAlbumu;
            this.DataRozpoczecia = s.DataRozpoczecia;
            this.Grupa = RepoGrupy.PobierzGrupeOId(s.IdGrupy);
            this.Oceny = RepoOceny.PobierzOcenyStudenta((sbyte)s.Id_student);
            var Kursy = this.Oceny.Select(ocena => RepoKursy.PobierzKursID(ocena.Id_kurs)).ToArray();
            var wagi = Kursy.Select(kurs => (double)(RepoPrzedmioty.PobierzPrzedmiot(kurs.Id_przedmiot).ECTS)).ToArray();
            var oceny = Oceny.Select(ocena => double.Parse(ocena.Wartosc)).ToArray();

            this.Osiagniecia = new List<WidokOsiagniecia>();
            List<Osiagniecia> osiagniecia = RepoOsiagniecia.PobierzOsiagnieciaStudenta((sbyte)s.Id_student);
            foreach (Osiagniecia o in osiagniecia)
            {
                Osiagniecia.Add(new WidokOsiagniecia(o));
            }

            this.Przedmioty = new List<WidokPrzedmiotu>();
            this.Srednia = oceny.Sum() * wagi.Sum() / wagi.Sum();
            this.Punkty = this.Srednia * 10 + (this.Osiagniecia.Select(osiagniecie => (int)osiagniecie.Punkty).ToArray()).Sum();
            if (this.Punkty > 60)
            {
                this.Stypendium = "Tak";
            }
            else
            {
                this.Stypendium = "Nie";
            }
        }
    }
}
