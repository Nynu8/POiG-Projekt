using Google.Protobuf.WellKnownTypes;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Navigation;

namespace POiG_Projekt.ViewModel.Details
{
    class CourseDetailsViewModel : ViewModelBase
    {
        public CourseDetailsViewModel()
        {

        }

        List<WidokStudenta> uczestnicy;
        public List<WidokStudenta> Uczestnicy
        {
            get
            {
                return uczestnicy;
            }
            set
            {
                uczestnicy = value;
                OnPropertyChanged();
            }
        }

        ICommand updateGrades = null;
        public ICommand UpdateGrades
        {
            get
            {
                if (updateGrades == null)
                {
                    updateGrades = new RelayCommand(
                        arg =>
                        {
                            //this.SelectedGrupa = null;
                            //this.SelectedRok = null;
                            //this.Studenci = this.model.Studenci;
                        },
                        arg =>
                        {
                            return true;
                        }
                        );
                }
                return updateGrades;
            }
        }


    }
}
