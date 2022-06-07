using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_ASP.Net_Core.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }
        public void OnGetContact()
        {
            Message = "email sent to team";
        }
        public void OnGetSubscribe() 
        {
            Message = "added to mailing list";
        }
    }
}
