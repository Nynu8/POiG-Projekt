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

        private WidokKursu selectedKurs;
        public WidokKursu SelectedKurs
        {
            get => selectedKurs;
            set
            {
                this.selectedKurs = value;
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
                            View.Details.CourseDetailsWindow courseDetails = new View.Details.CourseDetailsWindow();
                            courseDetails.LabelTytul.Content = selectedKurs.Przedmiot;
                            courseDetails.Grupa.Content = selectedKurs.Grupa;
                            courseDetails.iloscUczestnikow.Content = selectedKurs.Uczestnicy.Count.ToString();
                            courseDetails.Show();
                        },
                        arg =>
                        {
                            return (selectedKurs != null);
                        }
                        );
                }
                return showDetails;
            }
        }
    }

}
