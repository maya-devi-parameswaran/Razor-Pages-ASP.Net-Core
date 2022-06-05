using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASP.Net_Core.Models;
using Razor_Pages_ASP.Net_Core.Services;

namespace Razor_Pages_ASP.Net_Core.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Contact Contact { get; set; }
        public void OnGet()
        {
            Message = "Your contact page.";
        }
        public void OnPost()
        {
            if (ModelState.IsValid) 
            {
                EmailService.SendEmail(Contact);
                Message = "Your email has been sent!";
            }
          
        }

        public void OnPostSubscribe(string address) 
        {
          
                
                Message = "Joined!";
           
        }
    }
}
