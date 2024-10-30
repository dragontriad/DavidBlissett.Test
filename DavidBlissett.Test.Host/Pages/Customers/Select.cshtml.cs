using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DavidBlissett.Test.App.Services;
using DavidBlissett.Test.Shared;
using System.Threading.Tasks;
using DavidBlissett.Test.Host.Services;

namespace DavidBlissett.Test.App.Pages.Customers
{
    public class SelectModel : PageModel
    {
        private readonly ICustomerDataService _customerDataService;

        public SelectModel(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Customer = await _customerDataService.GetCustomerById(id);

            if (Customer == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
