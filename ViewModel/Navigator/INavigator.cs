using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel.Navigator
{
    internal enum ViewType
    {
        SignIn,
        MainPage,
        Home,
        Courses,
        Students,
        Professors,
        Subjects,
        Ranking,
        SubjectsDetails
    }

    internal interface INavigator
    {
        ViewModelBase CurrentVM { get; set; }
        ICommand UpdateCurrentVMCommand { get; }
    }
}
