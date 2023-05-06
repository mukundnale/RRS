using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace demo1.Models
{
    public class Seat
    {
        [Key]
        [Range(1, int.MaxValue)]
        public int SeatNo { get; set; }

        [Required]
        [ForeignKey("ReservationId")]
        public int ReservationId { get; set; }

        [Required]
        [RegularExpression("^(AC||SL)$", ErrorMessage = "Seat class should be either AC or SL")]
        public string SeatClass { get; set; }

        [JsonIgnore]
        public Reservation Reservation { get; set; }
    }
}