using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel
{
    class ProfessorsViewModel : ViewModelBase
    {
        private ListaProwadzacych model = null;
        private List<Prowadzacy> prowadzacy = null;
        public ProfessorsViewModel()
        {
            this.model = new ListaProwadzacych();
            this.prowadzacy = this.model.Prowadzacy;
        }

        public List<Prowadzacy> Prowadzacy
        {
            get => this.prowadzacy;
            set
            {
                this.prowadzacy = value;
                this.OnPropertyChanged();
            }
        }
    }
}
