using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASP.Net_Core.Models;
using Razor_Pages_ASP.Net_Core.Services;

namespace Razor_Pages_ASP.Net_Core.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);

                return RedirectToPage("Confirmation", "Contact");
                
            }
            return Page();
        }

        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);

            return RedirectToPage("Confirmation", "Subscribe");
        }
    }
}
