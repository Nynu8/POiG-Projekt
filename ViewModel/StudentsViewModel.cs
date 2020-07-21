using POiG_Projekt.DAL.Encje;
using POiG_Projekt.Model;
using POiG_Projekt.Model.Forms;
using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel
{
    class StudentsViewModel : ViewModelBase
    {
        private ListaStudentow model = null;
        private List<WidokStudenta> studenci = null;
        private List<int> rok = null;
        private List<Grupa> grupy = null;
        public StudentsViewModel()
        {
            this.model = new ListaStudentow();
            this.studenci = this.model.Studenci;
            this.rok = this.model.Rok;
        }

        public List<WidokStudenta> Studenci
        {
            get => this.studenci;
            set
            {
                this.studenci = value;
                this.OnPropertyChanged();
            }
        }
        public List<int> Rok
        {
            get => this.rok;
            set
            {
                this.rok = value;
                this.OnPropertyChanged();
            }
        }
        public List<Grupa> Grupy
        {
            get => this.grupy;
            set
            {
                this.grupy = value;
                this.OnPropertyChanged();
            }
        }
        private Grupa selectedGrupa;
        public Grupa SelectedGrupa
        {
            get => selectedGrupa;
            set
            {
                selectedGrupa = value;
                this.OnPropertyChanged();
                if (value != null)
                    this.Studenci = model.PobierzWybranychStudentow(value.Id_grupa);
                else
                    this.Studenci = null;
            }
        }
        private int? selectedRok;
        public int? SelectedRok
        {
            get => selectedRok;
            set
            {
                selectedRok = value;
                this.OnPropertyChanged();
                if (value != null)
                {
                    this.Grupy = model.PobierzWybraneGrupy((int)value);
                    this.Studenci = model.PobierzWybranychStudentowRok((int)value);
                }
                else
                    this.Grupy = null;
            }
        }

        private WidokStudenta selectedStudent;
        public WidokStudenta SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                onPropertyChanged();
            }
        }

        private ICommand showAll = null;
        public ICommand ShowAll
        {
            get
            {
                if (showAll == null)
                {
                    showAll = new RelayCommand(
                        arg =>
                        {
                            this.SelectedGrupa = null;
                            this.SelectedRok = null;
                            this.Studenci = this.model.Studenci;
                        },
                        arg =>
                        {
                            return true;
                        }
                        );
                }
                return showAll;
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
                            if (selectedStudent != null)
                            {
                                View.Details.StudentDetailsWindow subjectsDetails = new View.Details.StudentDetailsWindow();
                                subjectsDetails.Show();
                            }

                        },
                        arg =>
                        {
                            return true;
                        }
                        );
                }
                return showDetails;
            }
        }

        }
}
