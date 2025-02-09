using CustomersCoffeeApp.Model;

namespace CustomersCoffeeApp.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Yash", LastName = "Saini", IsDeveloper = true },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Doe", IsDeveloper = false },
                new Customer { Id = 3, FirstName = "John", LastName = "Smith", IsDeveloper = true },
                new Customer { Id = 4, FirstName = "Jane", LastName = "Smith", IsDeveloper = false },
                new Customer { Id = 5, FirstName = "John", LastName = "Johnson", IsDeveloper = true },
                new Customer { Id = 6, FirstName = "Jane", LastName = "Johnson", IsDeveloper = false },
                new Customer { Id = 7, FirstName = "John", LastName = "Brown", IsDeveloper = true },
                new Customer { Id = 8, FirstName = "Jane", LastName = "Brown", IsDeveloper = false },
                new Customer { Id = 9, FirstName = "John", LastName = "White", IsDeveloper = true },
                new Customer { Id = 10, FirstName = "Jane", LastName = "White", IsDeveloper = false }
            };
        }
    }
}
