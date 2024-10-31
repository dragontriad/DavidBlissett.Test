using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DavidBlissett.Test.Shared;
using DavidBlissett.Test.WebAPI.Models;
using Microsoft.Extensions.Configuration;

namespace DavidBlissett.Test.WebAPI.Models
{
    public class CustomerSQLRepository : ICustomerSQLRepository
    {
        private readonly AppDBContext _appDbContext;
        private readonly IConfiguration _configuration;

        public CustomerSQLRepository(AppDBContext appDbContext, IConfiguration configuration)
        {
            _appDbContext = appDbContext;
            _configuration = configuration;
        }

        // Add a new customer using stored procedure
        public Customer AddCustomer(Customer customer)
        {
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spAddCustomer";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                command.Parameters.Add(new SqlParameter("@Address1", customer.Address1));
                command.Parameters.Add(new SqlParameter("@Address2", customer.Address2));
                command.Parameters.Add(new SqlParameter("@PostCode", customer.PostCode));
                command.Parameters.Add(new SqlParameter("@TelephoneNumber", customer.TelephoneNumber));

                _appDbContext.Database.OpenConnection();
                customer.CustomerID = (int)(decimal)command.ExecuteScalar();
                _appDbContext.Database.CloseConnection();
            }

            return customer;
        }

        // Delete a customer by ID using stored procedure
        public void DeleteCustomer(int customerId)
        {
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spDeleteCustomer";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CustomerId", customerId));

                _appDbContext.Database.OpenConnection();
                command.ExecuteNonQuery();
                _appDbContext.Database.CloseConnection();
            }
        }

        // Get all customers using stored procedure
        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();

            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spGetAllCustomers";
                command.CommandType = CommandType.StoredProcedure;

                _appDbContext.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Address1 = reader.GetString(3),
                            Address2 = reader.IsDBNull(4) ? null : reader.GetString(4),
                            PostCode = reader.GetString(5),
                            TelephoneNumber = reader.GetString(6)
                        });
                    }
                }
                _appDbContext.Database.CloseConnection();
            }

            return customers;
        }

        // Get a customer by ID using stored procedure
        public Customer GetCustomerById(int customerId)
        {
            Customer customer = null;

            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spGetCustomerById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CustomerId", customerId));

                _appDbContext.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer
                        {
                            CustomerID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Address1 = reader.GetString(3),
                            Address2 = reader.IsDBNull(4) ? null : reader.GetString(4),
                            PostCode = reader.GetString(5),
                            TelephoneNumber = reader.GetString(6)
                        };
                    }
                }
                _appDbContext.Database.CloseConnection();
            }

            return customer;
        }

        // Update a customer using stored procedure
        public Customer UpdateCustomer(Customer customer)
        {
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spUpdateCustomer";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CustomerId", customer.CustomerID));
                command.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                command.Parameters.Add(new SqlParameter("@Address1", customer.Address1));
                command.Parameters.Add(new SqlParameter("@Address2", customer.Address2));
                command.Parameters.Add(new SqlParameter("@PostCode", customer.PostCode));
                command.Parameters.Add(new SqlParameter("@TelephoneNumber", customer.TelephoneNumber));

                _appDbContext.Database.OpenConnection();
                command.ExecuteNonQuery();
                _appDbContext.Database.CloseConnection();
            }

            return customer;
        }
    }
}
