//Data Transfer Object for User Registration.
using System.ComponentModel.DataAnnotations;

namespace dateapp.API.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Enter a password with no more than 10 characters and no less than 4")]
        public string Password { get; set; }
    }
}