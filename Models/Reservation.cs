using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        public string Source { get; set; }

        [Required]
        [StringLength(50)]
        public string Destination { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

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
        [Range(1, int.MaxValue)]
        [DisplayName("Reserved Total Seats")]
        public int TotalSeats { get; set; }

        [Required, Range(1, int.MaxValue)]
        public float TotalAmount { get; set; }

        [Required]
        public string Status { get; set; }

        [JsonIgnore]
        public IEnumerable<Passenger> Passenger { get; set; }

        [JsonIgnore]
        public Train Train { get; set; }

        [JsonIgnore]
        public Seat Seat { get; set; }
    }
}
