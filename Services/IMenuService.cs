using Razor_Pages_ASP.Net_Core.Models;

namespace Razor_Pages_ASP.Net_Core.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
