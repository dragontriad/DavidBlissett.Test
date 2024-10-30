using Microsoft.AspNetCore.Mvc.RazorPages;
using DavidBlissett.Test.App.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using DavidBlissett.Test.WebAPI.Models;
using DavidBlissett.Test.Shared;
using Microsoft.AspNetCore.Mvc;
using DavidBlissett.Test.Host.Services;


namespace DavidBlissett.Test.App.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerDataService _customerDataService;

        public IndexModel(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        public IEnumerable<Customer> Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _customerDataService.GetAllCustomers();
        }
    }
}
