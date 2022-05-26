using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ASP.Net_Core.Models;
using Razor_Pages_ASP.Net_Core.Services;

namespace Razor_Pages_ASP.Net_Core.Pages
{
    public class ItemModel : PageModel
    {
        public MenuItem? Item { get; private set; }

        public void OnGet(int id)
        {
            var menuService = new MenuService();
            Item = menuService.GetMenuItems().FirstOrDefault(i => i.Id == id);
        }
    }
}
