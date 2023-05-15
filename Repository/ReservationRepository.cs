using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Repository
{
    public class ReservationRepository : IReservation
    {
        private readonly RailwayContext railwayContext;

        public ReservationRepository(RailwayContext railwayContext)
        {
            this.railwayContext = railwayContext;
        }

        public async Task<List<Reservation>> GetAllReservations()
        {
            return await railwayContext.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservationById(int id)
        {
            return await railwayContext.Reservations.FirstOrDefaultAsync(x => x.ReservationId == id);
        }

        public async Task<Reservation> CancelReservation(int id)
        {
            var result = await railwayContext.Reservations.FindAsync(id);
            railwayContext.Reservations.Remove(result);
            await railwayContext.SaveChangesAsync();
            return result;
        }
    }
}
