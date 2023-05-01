using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Email Id is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? EmailId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public string? Role { get; set; }
    }
}
