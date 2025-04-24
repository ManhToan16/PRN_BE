using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

    }
}
