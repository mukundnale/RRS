using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public int PassengerId { get; set;}

        [Required]
        public int TrainId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Source { get; set; }

        [Required]
        [StringLength(50)]
        public string? Destination { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int NoOfPassengers { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int SeatNo { get; set; }

        [Required]
        public string? Status { get; set; }
    }
}
