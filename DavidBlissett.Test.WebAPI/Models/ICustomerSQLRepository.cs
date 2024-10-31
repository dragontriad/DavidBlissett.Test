using DavidBlissett.Test.Shared;
using System.Collections.Generic;

namespace DavidBlissett.Test.WebAPI.Models
{
    public interface ICustomerSQLRepository
    {
        Customer AddCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        Customer UpdateCustomer(Customer customer);

        // Additional methods specific to SQL-based repository (if needed)
    }
}
