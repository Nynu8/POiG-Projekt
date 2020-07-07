using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace POiG_Projekt.ViewModel.Navigator
{
    class Navigator : INavigator, INotifyPropertyChanged
    {
        private ViewModelBase currentVM;
        public ViewModelBase CurrentVM
        {
            get => this.currentVM;
            set
            {
                this.currentVM = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.onPropertyChanged(new[] { name });
        }
        protected void onPropertyChanged(params string[] namesOfProperties)
        {
            if (PropertyChanged != null)
            {
                foreach (var prop in namesOfProperties)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
                }
            }
        }

        public ICommand UpdateCurrentVMCommand => new UpdateCurrentVMCommand(this);
    }
}
