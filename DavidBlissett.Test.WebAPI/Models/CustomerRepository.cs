using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DavidBlissett.Test.Shared;
using DavidBlissett.Test.WebAPI.Models;

namespace DavidBlissett.Test.WebAPI.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDBContext _appDbContext;

        public CustomerRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Add a new customer
        public Customer AddCustomer(Customer customer)
        {
            var addedEntity = _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        // Delete a customer by ID
        public void DeleteCustomer(int customerId)
        {
            var foundCustomer = _appDbContext.Customers.FirstOrDefault(e => e.CustomerID == customerId);
            if (foundCustomer == null) return;

            _appDbContext.Customers.Remove(foundCustomer);
            _appDbContext.SaveChanges();
        }

        // Get all customers
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers
                                .OrderBy(c => c.LastName)
                                .ThenBy(c => c.FirstName)
                                .ToList();
        }

        // Get a customer by ID
        public Customer GetCustomerById(int customerId)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        // Update a customer
        public Customer UpdateCustomer(Customer customer)
        {
            var foundCustomer = _appDbContext.Customers.FirstOrDefault(e => e.CustomerID == customer.CustomerID);

            if (foundCustomer != null)
            {
                foundCustomer.FirstName = customer.FirstName;
                foundCustomer.LastName = customer.LastName;
                foundCustomer.Address1 = customer.Address1;
                foundCustomer.Address2 = customer.Address2;
                foundCustomer.PostCode = customer.PostCode;
                foundCustomer.TelephoneNumber = customer.TelephoneNumber;

                _appDbContext.SaveChanges();
                return foundCustomer;
            }

            return null;
        }
    }
}
