using Google.Protobuf.WellKnownTypes;
using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace POiG_Projekt.ViewModel
{
    class SubjectsViewModel : ViewModelBase
    {
        private ListaPrzedmiotow model = null;
        private List<Przedmiot> przedmioty = null;
        public SubjectsViewModel()
        {
            this.model = new ListaPrzedmiotow();
            this.przedmioty = this.model.Przedmioty;
        }
        public List<Przedmiot> Przedmioty
        {
            get
            {
                return this.przedmioty;
            }
            set
            {
                this.przedmioty = value;
                onPropertyChanged();
            }  
        }
    }
}
