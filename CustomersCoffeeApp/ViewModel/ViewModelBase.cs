﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomersCoffeeApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task LoadAsync()
        {
            return Task.CompletedTask;
        }
    }
}
