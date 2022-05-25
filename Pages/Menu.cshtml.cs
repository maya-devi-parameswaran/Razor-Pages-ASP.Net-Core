using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASP.Net_Core.Models;
using Razor_Pages_ASP.Net_Core.Services;

namespace Razor_Pages_ASP.Net_Core.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> Menu { get; set; }
        public void OnGet()
        {
            var menuService = new MenuService();
            Menu = menuService.GetMenuItems();
        }
    }
}
