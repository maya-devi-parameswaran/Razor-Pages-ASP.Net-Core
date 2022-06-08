using Microsoft.AspNetCore.Mvc;
using Razor_Pages_ASP.Net_Core.Services;

namespace Razor_Pages_ASP.Net_Core
{
    public class PopularBrews : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var menu = new MenuService();
            return View( menu.GetMenuItems().Take(count));
        }
    }
}
