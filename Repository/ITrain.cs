using Railway_Reservation.Models;

namespace Railway_Reservation.Repo.RailwayReservationRepository
{
    public interface ITrain
    {
        Task<List<Train>> GetTrains();

        Task<Train> CheckAvailability(string source, string destination, DateTime departureTime);
        Task<Train> AddTrain(Train train);

        Task<Train> UpdateTrain(int id, Train train);

        Task<bool> RemoveTrain(int trainid);
    }
}
