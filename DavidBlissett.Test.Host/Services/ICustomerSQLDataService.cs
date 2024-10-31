using DavidBlissett.Test.Shared;

public interface ICustomerSQLDataService
{
    Task<Customer> AddCustomer(Customer customer);
    Task DeleteCustomer(int customerId);
    Task<IEnumerable<Customer>> GetAllCustomers();
    Task<Customer> GetCustomerById(int customerId);
    Task UpdateCustomer(Customer customer);
}