using POiG_Projekt.DAL.Encje;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel.Details
{
    class StudentDetailsViewModel:ViewModelBase
    {
        private Student student;
        public StudentDetailsViewModel()
        {

        }

        public string Name
        {
            get => this.student.Imie;
        }

        public string Surname
        {
            get => this.student.Nazwisko;
        }

        public string Number
        {
            get => this.student.NrAlbumu;
        }

        public string Scholarship
        {
            get => this.student.Stypendium.ToString();
        }

        public string Points
        {
            get => this.student.Punkty.ToString();
        }

        public string StartDate
        {
            get => this.student.DataRozpoczecia;
        }

        public string Average
        {
            get => this.student.Srednia.ToString();
        }

        public string Email
        {
            get => this.student.Email;
        }

    }
}
