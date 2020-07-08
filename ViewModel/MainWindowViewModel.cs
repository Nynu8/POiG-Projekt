using POiG_Projekt.DAL;
using POiG_Projekt.ViewModel.Base;
using POiG_Projekt.ViewModel.Navigator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        public INavigator navigator { get; } = new Navigator.Navigator();
        public MainWindowViewModel()
        { 
            navigator.UpdateCurrentVMCommand.Execute(ViewType.Home);
            _ = DBConnection.Connection;
        }
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
                            MainWindow currentWindow = arg as MainWindow;
                            View.SignInWindow signInWindow = new View.SignInWindow();
                            currentWindow.Close();
                            signInWindow.Show();
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
