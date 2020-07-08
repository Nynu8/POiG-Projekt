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
        public StudentsViewModel()
        {
            this.model = new ListaStudentow();
            this.studenci = this.model.Studenci;
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
    }
}
