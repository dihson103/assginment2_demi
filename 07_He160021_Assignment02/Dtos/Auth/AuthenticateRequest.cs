using System.ComponentModel.DataAnnotations;

namespace _07_He160021_Assignment02.Dtos.Auth
{
    public class AuthenticateRequest
    {
        [Required]
        [Display(Name = "User name")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
