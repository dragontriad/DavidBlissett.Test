using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.WebAPI.Models
{
    public interface ICustomerRepository
    {
        // Add a new customer
        Customer AddCustomer(Customer customer);

        // Delete a customer by ID
        void DeleteCustomer(int customerId);

        // Get all customers
        IEnumerable<Customer> GetAllCustomers();

        // Get a customer by ID
        Customer GetCustomerById(int customerId);

        // Update an existing customer
        Customer UpdateCustomer(Customer customer);
    }
}
