using Railway_Reservation.Models;

namespace Railway_Reservation.Repo.RailwayReservationRepository
{
    public interface IPassenger
    {
        Task<List<Passenger>> GetAllPassenger();

        Task<Passenger> GetPassengerById(int id);

        Task<Passenger> AddPassenger(Passenger passenger);

        Task<Passenger> UpdatePassenger(int id, Passenger passenger);

        Task<Passenger> DeletePassengerById(int id);

    }
}