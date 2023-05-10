using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Railway_Reservation.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; } //primary key

        //------------------------------------------------------------

        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; } //foreign key

        //------------------------------------------------------------

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        //------------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("EmailId")]
        public string EmailId { get; set; }

        //------------------------------------------------------------

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        public string Password { get; set; }

        //------------------------------------------------------------

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [DisplayName("Phone Number")]
        public string Phone_no { get; set; }

        //------------------------------------------------------------

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        [DisplayName("Age")]
        public int age { get; set; }

        //------------------------------------------------------------

        [Required(ErrorMessage = "Gender is required")]
        [DisplayName("Gender")]
        public string gender { get; set; }

        //------------------------------------------------------------

        [JsonIgnore]
        public User User { get; set; }
    }
}