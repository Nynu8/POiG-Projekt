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
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() { Navigator.UpdateCurrentVMCommand.Execute(ViewType.SignIn); }
        public static INavigator Navigator { get; set; } = new Navigator.Navigator();

    }
}
