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
        public string Srednia { get; set; }
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
            if (s.Stypendium)
                this.Stypendium = "Tak";
            else
                this.Stypendium = "Nie";
            this.Grupa = RepoGrupy.PobierzGrupeOId(s.IdGrupy);
            this.Oceny = RepoOceny.PobierzOcenyStudenta((sbyte)s.Id_student);
            this.Osiagniecia = new List<WidokOsiagniecia>();
            List<Osiagniecia> osiagniecia = RepoOsiagniecia.PobierzOsiagnieciaStudenta((sbyte)s.Id_student);
            foreach (Osiagniecia o in osiagniecia)
            {
                Osiagniecia.Add(new WidokOsiagniecia(o));
            }
            this.Przedmioty = new List<WidokPrzedmiotu>();//to do: połączyć studenta przez grupę i dalej przez kurs do przedmiotów jakie ma xd
        }
    }
}
