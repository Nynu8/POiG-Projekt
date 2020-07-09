using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel
{
    class CoursesViewModel : ViewModelBase
    {
        private ListaKursow model = null;
        private List<WidokKursu> kursy = null;
        public CoursesViewModel()
        {
            this.model = new ListaKursow();
            this.kursy = this.model.Kursy;
        }

        public List<WidokKursu> Kursy
        {
            get => this.kursy;
            set
            {
                this.kursy = value;
                this.OnPropertyChanged();
            }
        }
    }
}
