using Microsoft.AspNetCore.Identity;

namespace PRN_BE.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public byte[]? avatar { get; set; }

    }
}
