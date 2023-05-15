using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Repository
{
    public class SeatRepository : ISeat
    {
        private readonly RailwayContext railwayContext;

        public SeatRepository(RailwayContext railwayContext)
        {
            this.railwayContext = railwayContext;
        }
        public async Task<List<Seat>> GetSeats()
        {
            return await railwayContext.Seats.ToListAsync();
        }

        public async Task<Seat> GetSeatByNo(int seatno)
        {
            return await railwayContext.Seats.FirstOrDefaultAsync(x => x.SeatNo == seatno);
        }

        public async Task<Seat> GetReservationId(int reservationid)
        {
            return await railwayContext.Seats.FirstOrDefaultAsync(x => x.ReservationId == reservationid);
        }
    }
}
