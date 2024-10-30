using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DavidBlissett.Test.App.Services;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DavidBlissett.Test.Shared;
using DavidBlissett.Test.Host.Services;

namespace DavidBlissett.Test.App.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly ICustomerDataService _customerDataService;

        public CreateModel(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Validate the postcode format (UK format example)
            var postcodePattern = @"^[A-Z]{1,2}\d[A-Z\d]? ?\d[A-Z]{2}$";
            if (!Regex.IsMatch(Customer.PostCode, postcodePattern, RegexOptions.IgnoreCase))
            {
                ModelState.AddModelError("Customer.PostCode", "Invalid postcode format.");
                return Page();
            }

            // Validate the phone number format (simple example for UK phone numbers)
            var phonePattern = @"^\d{3,4}-\d{3}-\d{4}$";  // Adjust this pattern as needed
            if (!Regex.IsMatch(Customer.TelephoneNumber, phonePattern))
            {
                ModelState.AddModelError("Customer.TelephoneNumber", "Invalid phone number format. Expected format: 0123-456-7890.");
                return Page();
            }

            await _customerDataService.AddCustomer(Customer);
            return RedirectToPage("Index");
        }
    }
}
