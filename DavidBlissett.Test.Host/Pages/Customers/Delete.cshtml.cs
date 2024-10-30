using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DavidBlissett.Test.App.Services;
using System.Threading.Tasks;
using DavidBlissett.Test.WebAPI.Models;
using DavidBlissett.Test.Host.Services;
using DavidBlissett.Test.Shared;

namespace DavidBlissett.Test.App.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        private readonly ICustomerDataService _customerDataService;

        public DeleteModel(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _customerDataService.DeleteCustomer(id);
            return RedirectToPage("Index");
        }
    }
}
