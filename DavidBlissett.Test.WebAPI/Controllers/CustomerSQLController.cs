using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DavidBlissett.Test.WebAPI.Models;
using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSQLController : ControllerBase
    {
        private readonly ICustomerSQLRepository _customerSQLRepository;

        public CustomerSQLController(ICustomerSQLRepository customerSQLRepository)
        {
            _customerSQLRepository = customerSQLRepository;
        }

        // Get all customers using SQL repository
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = _customerSQLRepository.GetAllCustomers();
            return Ok(customers);
        }

        // Get a customer by ID using SQL repository
        [HttpGet("GetById/{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerSQLRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // Add a new customer using SQL repository
        [HttpPost("Add")]
        public ActionResult<Customer> AddCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer data is invalid.");
            }

            var addedCustomer = _customerSQLRepository.AddCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = addedCustomer.CustomerID }, addedCustomer);
        }

        // Update an existing customer using SQL repository
        [HttpPut("Update")]
        public ActionResult<Customer> UpdateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer data is invalid.");
            }

            var updatedCustomer = _customerSQLRepository.UpdateCustomer(customer);
            if (updatedCustomer == null)
            {
                return NotFound();
            }
            return Ok(updatedCustomer);
        }

        // Delete a customer by ID using SQL repository
        [HttpDelete("Delete/{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customer = _customerSQLRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }

            _customerSQLRepository.DeleteCustomer(id);
            return NoContent();
        }
    }
}
