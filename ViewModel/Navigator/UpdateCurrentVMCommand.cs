using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel.Navigator
{
    class UpdateCurrentVMCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;
        public UpdateCurrentVMCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType viewType)
            {
                switch (viewType)
                {
                    case ViewType.Courses:
                        _navigator.CurrentVM = new CoursesViewModel();
                        break;
                    case ViewType.Home:
                        _navigator.CurrentVM = new HomeViewModel();
                        break;
                    case ViewType.Professors:
                        _navigator.CurrentVM = new ProfessorsViewModel();
                        break;
                    case ViewType.Students:
                        _navigator.CurrentVM = new StudentsViewModel();
                        break;
                    case ViewType.Subjects:
                        _navigator.CurrentVM = new SubjectsViewModel();
                        break;
                    case ViewType.SubjectsDetails:
                        _navigator.CurrentVM = new Details.SubjectsDetailsViewModel();
                        break;
                    case ViewType.MainPage:
                        _navigator.CurrentVM = new MainPageViewModel();
                        break;
                    case ViewType.SignIn:
                        _navigator.CurrentVM = new SignInViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
