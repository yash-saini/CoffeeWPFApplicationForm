using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersCoffeeApp.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        private readonly CustomersViewModel _customersViewModel;

        public ViewModelBase? SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel(CustomersViewModel customersViewModel)
        {
            _customersViewModel = customersViewModel;
            SelectedViewModel = _customersViewModel;
        }

        public async override Task LoadAsync()
        {
            if(SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }
    }
}
