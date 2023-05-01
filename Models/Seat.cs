using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Seat
    {
        [Key]
        [Required]
        [Range(1, int.MaxValue)]
        public int SeatNo { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        [RegularExpression("^(AC||SL)$", ErrorMessage = "Seat class should be either AC or SL")]
        public string? SeatClass { get; set; }
    }
}
