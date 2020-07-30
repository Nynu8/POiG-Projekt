using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1;
using POiG_Projekt.DAL.Encje;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        List<WidokOcenStudenta> uczestnicy = new List<WidokOcenStudenta>();
        public List<WidokOcenStudenta> Uczestnicy
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
                            foreach (WidokOcenStudenta uczestnik in Uczestnicy)
                            {
                                RepoOceny.WprowadzOcene(uczestnik.IdKursuOceny, uczestnik.ID, uczestnik.NowaOcena);
                            }
                            OnPropertyChanged(nameof(Uczestnicy));
                        },
                        arg =>
                        {
                            foreach(WidokOcenStudenta uczestnik in Uczestnicy)
                            {

                                if (!uczestnik.ObecnaOcena.Equals(uczestnik.NowaOcena))
                                    return true;
                            }
                            return false;
                        }
                        );
                }
                return updateGrades;
            }
        }
    }
}
