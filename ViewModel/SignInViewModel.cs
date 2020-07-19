using POiG_Projekt.DAL;
using POiG_Projekt.Model;
using POiG_Projekt.View;
using POiG_Projekt.ViewModel.Base;
using POiG_Projekt.ViewModel.Navigator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel
{
    class SignInViewModel : ViewModelBase
    {
        private string nazwaUzytkownika;
        public string NazwaUzytkownika
        {
            get { return nazwaUzytkownika; }
            set
            {
                nazwaUzytkownika = value;
                OnPropertyChanged(NazwaUzytkownika);
                Error = "";
            }
        }

        private string haslo;
        public string Haslo
        {
            get { return haslo; }
            set
            {
                haslo = value;
                OnPropertyChanged(Haslo);
                Error = "";
            }
        }

        private string error;
        public string Error
        {
            get { return error; }
            set
            {
                error = value;
                onPropertyChanged(nameof(Error));
            }
        }

        private ICommand showMenu = null;
        public ICommand ShowMenu
        {
            get
            {
                if (showMenu == null)
                {
                    showMenu = new RelayCommand(
                        arg =>
                        {
                            DBConnection.ID = 1;
                            MainWindowViewModel.Navigator.UpdateCurrentVMCommand.Execute(ViewType.MainPage);
                        },
                        arg =>
                        {
                            return true;
                        }
                        );
                }
                return showMenu;
            }
        }

        private ICommand login = null;
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(
                        arg =>
                        {
                            try
                            {
                                DBConnection.ID = Logowanie.GetID(nazwaUzytkownika, haslo);
                                if (DBConnection.ID != 0)
                                {
                                    MainWindowViewModel.Navigator.UpdateCurrentVMCommand.Execute(ViewType.MainPage);
                                }
                                else
                                    Error = "Podano zły login lub hasło";
                            }
                            catch (Exception e)
                            {
                                Error = e.Message;
                            }
                        },
                        arg =>
                        {
                            return !(String.IsNullOrEmpty(Haslo) && String.IsNullOrEmpty(NazwaUzytkownika));
                        }
                        );
                }
                return login;
            }
        }
    }
}
