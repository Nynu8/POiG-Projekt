using POiG_Projekt.DAL;
using POiG_Projekt.DAL.Repozytoria;
using POiG_Projekt.Model;
using POiG_Projekt.ViewModel.Base;
using POiG_Projekt.ViewModel.Navigator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        public INavigator navigator { get; } = new Navigator.Navigator();
        public MainPageViewModel()
        {
            navigator.UpdateCurrentVMCommand.Execute(ViewType.Home);
            _ = DBConnection.Connection;
            date = DateTime.Now;
            currentUser = ListaProwadzacych.PobierzUzytkownika();
        }

        #region properties
        //to do: update daty albo liczyć że nikt z tego nie będzie korzystał koło północy XD
        DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                onPropertyChanged();
            }
        }

        string currentUser;
        public string CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                onPropertyChanged();
            }
        }
        #endregion
        public ICommand NavigateCommand => navigator.UpdateCurrentVMCommand;

        private ICommand signOut = null;
        public ICommand SignOut
        {
            get
            {
                if (signOut == null)
                {
                    signOut = new RelayCommand(
                        arg =>
                        {
                            DBConnection.ID = 0;
                            MainWindowViewModel.Navigator.UpdateCurrentVMCommand.Execute(ViewType.SignIn);
                        },
                        arg =>
                        {
                            return true;
                        }
                        );
                }
                return signOut;
            }
        }

    }
}
