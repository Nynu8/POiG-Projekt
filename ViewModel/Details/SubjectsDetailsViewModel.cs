using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel.Details
{
    class SubjectsDetailsViewModel : ViewModelBase
    {
        private ListaEfektow model = null;
        private List<WidokEfekt> opisy = null;
        private Przedmiot przedmiot;
        public SubjectsDetailsViewModel()
        {

        }
        //public string Name
        //{
        //    get => this.przedmiot.Nazwa;
        //}
        //public string Skrot
        //{
        //    get => this.przedmiot.Skrot;
        //}
        //public string FormaZaliczenia
        //{
        //    get => this.przedmiot.Rodzaj;
        //}
        //public string ECTS
        //{
        //    get => this.przedmiot.ECTS.ToString();
        //}
        public List<WidokEfekt> Efeky
        {
            get => this.opisy;
            set
            {
                this.opisy = value;
                this.OnPropertyChanged();
            }
        }
    }
}
