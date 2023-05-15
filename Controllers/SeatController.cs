using Microsoft.AspNetCore.Mvc;
using Railway_Reservation.Models;
using Railway_Reservation.Repository;

namespace Railway_Reservation.Controllers
{
    public class SeatController : Controller
    {
        private readonly ISeat seat;

        public SeatController(ISeat seat)
        {
            this.seat = seat;
        }

        [HttpGet]
        public async Task<ActionResult<List<Seat>>> GetSeats()
        {
            return await seat.GetSeats();
        }

        [HttpGet("{seatno}")]
        public async Task<ActionResult<Seat>> GetSeatByNo(int seatno)
        {
            return await seat.GetSeatByNo(seatno);
        }

        [HttpGet("reservation/{reservationid}")]
        public async Task<ActionResult<Seat>> GetReservationId(int reservationid)
        {
            return await seat.GetReservationId(reservationid);
        }
    }
}
