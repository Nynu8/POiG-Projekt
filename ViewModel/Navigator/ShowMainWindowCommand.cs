using POiG_Projekt.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel.Navigator
{
    class ShowMainWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SignInWindow currentWindow = parameter as SignInWindow;
            MainWindow objPopupwindow = new MainWindow();
            currentWindow.Close();
            objPopupwindow.Show();
        }
    }
}
