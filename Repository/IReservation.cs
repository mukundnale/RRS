using Railway_Reservation.Models;

namespace Railway_Reservation.Repository
{
    public interface IReservation
    {
        Task<List<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationById(int id);
        Task<Reservation> CancelReservation(int id);
    }
}
