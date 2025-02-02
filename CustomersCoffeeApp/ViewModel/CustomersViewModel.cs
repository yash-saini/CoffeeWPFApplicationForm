using CustomersCoffeeApp.Command;
using CustomersCoffeeApp.Data;
using CustomersCoffeeApp.Model;
using System.Collections.ObjectModel;

namespace CustomersCoffeeApp.ViewModel
{
    public class CustomersViewModel : ViewModelBase
     {
        private readonly ICustomerDataProvider _customerDataProvider;
        public DelegateCommand AddCommand { get; }
        public DelegateCommand MoveCommand { get; }
        public DelegateCommand DeleteCommand { get; }
        private CustomerItemViewModel? _selectedCustomer;
        private NavigationDirection _navigationSide;

        public ObservableCollection<CustomerItemViewModel> Customers { get; } = new();

        public NavigationDirection NavigationSide
        { 
            get => _navigationSide;
            private set
            {
                _navigationSide = value;
                RaisePropertyChanged();
            }
        }

        public enum NavigationDirection
        {
            Left,
            Right
        }

        public CustomersViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            AddCommand = new DelegateCommand(_ => AddCustomer(new Customer()));
            MoveCommand = new DelegateCommand(MoveNavigation);
            DeleteCommand = new DelegateCommand(Delete,CanDelete);
        }

        public void LoadCustomers()
        {
            if (Customers.Count > 0) return;
            foreach (var customer in _customerDataProvider.GetCustomers())
            {
                Customers.Add(new CustomerItemViewModel(customer));
            }
        }

        public CustomerItemViewModel? SelectedCustomer {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsCustomerSelected));
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public bool IsCustomerSelected => SelectedCustomer is not null;

        private void AddCustomer(Customer customer)
        {
            var viewModel = new CustomerItemViewModel(customer);
            Customers.Add(viewModel);
            SelectedCustomer = viewModel;
        }

        private void MoveNavigation(object? parameter)
        {
            NavigationSide = NavigationSide == NavigationDirection.Left
                ? NavigationDirection.Right
                : NavigationDirection.Left;
        }

        private void Delete(object? parameter)
        {
            if (SelectedCustomer != null)
            {
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
            }
        }

        private bool CanDelete(object? parameter)
        {
            return SelectedCustomer != null;
        }
    }
}
