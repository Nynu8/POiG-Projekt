using Google.Protobuf.WellKnownTypes;
using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using POiG_Projekt.View.Details;
using POiG_Projekt.ViewModel.Details;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel
{
    class SubjectsViewModel : ViewModelBase
    {
        private ListaPrzedmiotow model = null;
        private List<WidokPrzedmiotu> przedmioty = null;
        public SubjectsViewModel()
        {
            this.model = new ListaPrzedmiotow();
            this.przedmioty = this.model.Przedmioty;
        }
        public List<WidokPrzedmiotu> Przedmioty
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
        private WidokPrzedmiotu selectedPrzedmiot;
        public WidokPrzedmiotu SelectedPrzedmiot
        {
            get => selectedPrzedmiot;
            set
            {
                this.selectedPrzedmiot = value;
                onPropertyChanged();
            }
        }

        private ICommand showDetails = null;
        public ICommand ShowDetails
        {
            get
            {
                if (showDetails == null)
                {
                    showDetails = new RelayCommand(
                        arg =>
                        {
                            View.Details.SubjectsDetailsWindow subjectsDetails = new View.Details.SubjectsDetailsWindow();
                            subjectsDetails.LabelTytul.Content = selectedPrzedmiot.Nazwa;
                            subjectsDetails.Skrot.Content = selectedPrzedmiot.Skrot;
                            subjectsDetails.ects.Content = selectedPrzedmiot.ECTS;
                            subjectsDetails.Rodzaj.Content = selectedPrzedmiot.FormaZaliczenia;
                            //subjectsDetails.ListViewEfekty.ItemsSource = ListaEfektow.OpisyEfektow(SelectedPrzedmiot.Id_przedmiot);
                            subjectsDetails.Show();
                        },
                        arg =>
                        {
                            return (selectedPrzedmiot != null);
                        }
                        );
                }
                return showDetails;
            }
        }
    }
}
