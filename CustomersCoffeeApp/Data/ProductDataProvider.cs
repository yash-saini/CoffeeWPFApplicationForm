using CustomersCoffeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersCoffeeApp.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>?> GetAllAsync();
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Product>
            {
                new Product {Name = "Flat White", Description = "Coffee"},
                new Product {Name = "Chai Tea Latte", Description = "Tea"}
            };
        }
    }
}
