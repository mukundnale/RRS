
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Railway_Reservation.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; } //primary key

        //------------------------------------------------------------

        [Required]
        [ForeignKey("PassengerId")]
        public int PassengerId { get; set; } //foreign key

        //------------------------------------------------------------

        [Required]
        [ForeignKey("TrainId")]
        public int TrainId { get; set; } //foreign key

        //------------------------------------------------------------


        [Required]
        [StringLength(50)]
        public string Source { get; set; }

        //------------------------------------------------------------

        [Required]
        [StringLength(50)]
        public string Destination { get; set; }

        //------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }

        //------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

        //------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        //------------------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        public int Number_of_Passengers { get; set; }

        //------------------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        [ForeignKey("SeatNo")]
        public int SeatNo { get; set; } //foreign key

        //------------------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Reserved Total Seats")]
        public int TotalSeats { get; set; }

        //------------------------------------------------------------

        [Required, Range(1, int.MaxValue)]
        public float TotalAmount { get; set; }

        //------------------------------------------------------------

        [Required]
        public string Reservation_status { get; set; }

        //------------------------------------------------------------

        [JsonIgnore]
        public IEnumerable<Passenger> Passenger { get; set; }

        [JsonIgnore]
        public Train Train { get; set; }

        [JsonIgnore]
        public Seat Seat { get; set; }

    }
}