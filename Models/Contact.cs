using System.ComponentModel.DataAnnotations;

namespace Razor_Pages_ASP.Net_Core.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
