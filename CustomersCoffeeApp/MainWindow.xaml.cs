﻿using CustomersCoffeeApp.Data;
using CustomersCoffeeApp.ViewModel;
using System.Windows;

namespace CustomersCoffeeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new CustomersViewModel(new CustomerDataProvider()), new ProductsViewModel());
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        //private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Add Customer button clicked");
        //}

    }
}