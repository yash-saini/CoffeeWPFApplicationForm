using CustomersCoffeeApp.Command;
using CustomersCoffeeApp.Data;
using CustomersCoffeeApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersCoffeeApp.ViewModel
{
    public class ProductsViewModel : ViewModelBase
    {
        private IProductDataProvider _productDataProvider;

        public ProductsViewModel(IProductDataProvider productDataProvider)
        {
            _productDataProvider = productDataProvider;
        }
        public ObservableCollection<Product> Products { get; } = new();

        public async override Task LoadAsync()
        {
            if (Products.Count > 0) return;
            var products = await _productDataProvider.GetAllAsync();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

    }
}
