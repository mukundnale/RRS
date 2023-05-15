namespace Railway_Reservation.DTO
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }
        public int PassengerId { get; set; }
        public int TrainId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Number_of_Passengers { get; set; }
        public int SeatNo { get; set; }
        public float TotalAmount { get; set; }
        public string Reservation_status { get; set; }

    }
}
