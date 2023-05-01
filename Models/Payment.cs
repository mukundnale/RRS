using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int ReservationId { get; set; }

        [Required]
        public DateTime PaymentDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string? PaymentMethod { get; set; }

        [Required]
        [StringLength(50)]
        public string? PaymentStatus { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalAmount { get; set; }
    }
}
