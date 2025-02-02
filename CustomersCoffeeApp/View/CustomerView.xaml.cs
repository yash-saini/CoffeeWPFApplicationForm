using CustomersCoffeeApp.Data;
using CustomersCoffeeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomersCoffeeApp.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        private readonly CustomersViewModel _viewModel;

        public CustomerView()
        {
            InitializeComponent();
            _viewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += CustomerView_Loaded;
        }

        private void CustomerView_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadCustomers();
        }

        //private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        //{
        //    //var column = (int)  customerListGrid.GetValue(Grid.ColumnProperty);
        //    //  if (column == 0)
        //    //  {
        //    //      customerListGrid.SetValue(Grid.ColumnProperty, 2);
        //    //  }
        //    //  else
        //    //  {
        //    //      customerListGrid.SetValue(Grid.ColumnProperty, 0);
        //    //  }

        //    //Using the following code to move the grid column

        //    //var column = Grid.GetColumn(customerListGrid);
        //    //if (column == 0)
        //    //{
        //    //    Grid.SetColumn(customerListGrid, 2);
        //    //}
        //    //else
        //    //{
        //    //    Grid.SetColumn(customerListGrid, 0);
        //    //}

        //    _viewModel.MoveNavigation();
        //}

        //private void ButtonAddNavigation_Click(object sender, RoutedEventArgs e)
        //{
        //    _viewModel.AddCustomer(new Model.Customer { Id = 11, FirstName = "", LastName = "", IsDeveloper = true });
        //}
    }
}
