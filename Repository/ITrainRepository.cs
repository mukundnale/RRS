using Railway_Reservation.Models;

namespace Railway_Reservation.Repo.RailwayReservationRepository
{
    public interface ITrainRepository
    {
        Task<List<Train>> GetTrains();

        Task<Train> CheckAvailability(string source, string destination, DateTime departureTime);
    }
}
