using System.Windows.Controls;

namespace CustomersCoffeeApp.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        //private readonly CustomersViewModel _viewModel;

        public CustomerView()
        {
            InitializeComponent();
            //_viewModel = new CustomersViewModel(new CustomerDataProvider());
            //DataContext = _viewModel;
            //Loaded += CustomerView_Loaded;
        }

        //private  async void CustomerView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    await _viewModel.LoadAsync();
        //}

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
