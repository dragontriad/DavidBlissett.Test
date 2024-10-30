using Microsoft.AspNetCore.Mvc;
using DavidBlissett.Test.WebAPI.Models;
using System.Collections.Generic;
using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.WebAPI.Controllers
{
    // Defines the route for this API controller, which will be "api/Customer"
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // A readonly field to hold the injected customer repository
        private readonly ICustomerRepository _customerRepository;

        // Constructor to inject ICustomerRepository dependency via Dependency Injection
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customer
        // Retrieves all customers from the repository and returns them in the response
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            return Ok(customers); // Returns 200 OK status with the list of customers
        }

        // GET api/Customer/5
        // Retrieves a specific customer by ID. Returns 404 Not Found if the customer is not found
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound(); // Returns 404 Not Found if the customer does not exist
            }
            return Ok(customer); // Returns 200 OK status with the customer data
        }

        // POST api/Customer
        // Adds a new customer to the repository. Returns 201 Created if successful
        [HttpPost]
        public ActionResult<Customer> PostCustomer([FromBody] Customer customer)
        {
            // Validate the incoming customer data
            if (customer == null)
            {
                return BadRequest(); // Returns 400 Bad Request if customer data is null
            }

            var addedCustomer = _customerRepository.AddCustomer(customer);
            // Returns 201 Created with a reference to the new customer
            return CreatedAtAction(nameof(GetCustomerById), new { id = addedCustomer.CustomerID }, addedCustomer);
        }

        // PUT api/Customer/5
        // Updates an existing customer based on the provided ID and data
        [HttpPut("{id}")]
        public IActionResult PutCustomer(int id, [FromBody] Customer customer)
        {
            // Check if the ID in the URL matches the customer's ID, and validate customer data
            if (id != customer.CustomerID || customer == null)
            {
                return BadRequest(); // Returns 400 Bad Request if IDs don't match or data is invalid
            }

            var updatedCustomer = _customerRepository.UpdateCustomer(customer);
            if (updatedCustomer == null)
            {
                return NotFound(); // Returns 404 Not Found if the customer does not exist
            }

            return NoContent(); // Returns 204 No Content on a successful update
        }

        // DELETE api/Customer/5
        // Deletes a customer by ID. Returns 404 Not Found if the customer doesn't exist
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var existingCustomer = _customerRepository.GetCustomerById(id);
            if (existingCustomer == null)
            {
                return NotFound(); // Returns 404 Not Found if the customer does not exist
            }

            _customerRepository.DeleteCustomer(id);
            return NoContent(); // Returns 204 No Content on a successful delete
        }
    }
}
