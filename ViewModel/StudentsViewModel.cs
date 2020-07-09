using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel
{
    class StudentsViewModel : ViewModelBase
    {
        private ListaStudentow model = null;
        private List<Student> studenci = null;
        private List<Semestr> semestry = null;
        private List<Grupa> grupy = null;
        public StudentsViewModel()
        {
            this.model = new ListaStudentow();
            this.studenci = this.model.Studenci;
            this.semestry = this.model.Semestry;
            this.grupy = this.model.Grupy;
        }

        public List<Student> Studenci
        {
            get => this.studenci;
            set
            {
                this.studenci = value;
                this.OnPropertyChanged();
            }
        }
        public List<Semestr> Semestry
        {
            get => this.semestry;
            set
            {
                this.semestry = value;
                this.OnPropertyChanged();
            }
        }
        public List<Grupa> Grupy
        {
            get => this.grupy;
            set
            {
                this.grupy = value;
                this.OnPropertyChanged();
            }
        }
        private Grupa selectedGrupa;
        public Grupa SelectedGrupa
        {
            get => selectedGrupa;
            set
            {
                selectedGrupa = value;
                this.OnPropertyChanged();
                this.Studenci = model.PobierzWybranychStudentow(value.Id_grupa);
            }
        }
    }
}
