using Microsoft.AspNetCore.Mvc.RazorPages;
using DavidBlissett.Test.App.Services;
using DavidBlissett.Test.WebAPI.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using DavidBlissett.Test.Host.Services;
using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.Host.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICustomerDataService _customerDataService;

        public IndexModel(ILogger<IndexModel> logger, ICustomerDataService customerDataService)
        {
            _logger = logger;
            _customerDataService = customerDataService;
        }

        // Property to hold the list of customers
        public IEnumerable<Customer> Customers { get; private set; }

        // Fetch all customers when the page loads
        public async Task OnGetAsync()
        {
            Customers = await _customerDataService.GetAllCustomers();
        }
    }
}
