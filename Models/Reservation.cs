using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo1.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        [ForeignKey("PassengerId")]
        public int PassengerId { get; set;}

        [Required]
        [ForeignKey("TrainId")]
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
        [ForeignKey("SeatNo")]
        public int SeatNo { get; set; }

        [Required]
        public string? Status { get; set; }

        public Passenger Passenger { get; set; }

        public Train Train { get; set; }

        public Seat Seat { get; set; }
    }
}
