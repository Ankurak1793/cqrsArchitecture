using System.ComponentModel.DataAnnotations;

namespace Demo.Core.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}