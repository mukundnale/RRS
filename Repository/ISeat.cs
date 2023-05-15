using Railway_Reservation.Models;

namespace Railway_Reservation.Repository
{
    public interface ISeat
    {
        Task<List<Seat>> GetSeats();
        Task<Seat> GetSeatByNo(int seatno);
        Task<Seat> GetReservationId(int reservationid);
    }
}
