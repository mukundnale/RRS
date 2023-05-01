using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Train
    {
        [Key]
        public int TrainId { get; set; }

        [Required(ErrorMessage = "Train name is required")]
        [StringLength(50, ErrorMessage = "Train name cannot be longer than 50 characters")]
        public string? TrainName { get; set;}

        [Required(ErrorMessage = "Source is required")]
        [StringLength(50, ErrorMessage = "Source cannot be longer than 50 characters")]
        public string? Source { get; set;}

        [Required(ErrorMessage = "Destination is required")]
        [StringLength(50, ErrorMessage = "Destination cannot be longer than 50 characters")]
        public string? Destination { get; set;}

        [Required(ErrorMessage = "Departure time is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid departure time format")]
        public DateTime DepartureTime { get; set; }

        [Required(ErrorMessage = "Arrival time is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid arrival time format")]
        public DateTime ArrivalTime { get; set;}

        [Required(ErrorMessage = "Total seats is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Total seats should be greater than 0")]
        public int TotalSeats { get; set; }

        [Required(ErrorMessage = "Available seats is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Available seats should be greater than or equal to 0")]
        public int AvailableSeats { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater than 0")]
        public int Price { get; set; }
    }
}
