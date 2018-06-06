using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(99, MinimumLength = 8, ErrorMessage = "Password must me more than 8 characters long.")]
        public string Password { get; set; }
    }
}