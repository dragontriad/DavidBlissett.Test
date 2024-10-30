using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.Host.Services
{
    public interface ICustomerDataService
    {
        Task<Customer> AddCustomer(Customer customer);
        Task DeleteCustomer(int customerId);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int customerId);
        Task UpdateCustomer(Customer customer);
    }
}
