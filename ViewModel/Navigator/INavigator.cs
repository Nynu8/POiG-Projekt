﻿using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel.Navigator
{
    internal enum ViewType
    {
        Home,
        Courses,
        Students,
        Professors,
        Subjects,
        Ranking
    }

    internal interface INavigator
    {
        ViewModelBase CurrentVM { get; set; }
        ICommand UpdateCurrentVMCommand { get; }
    }
}