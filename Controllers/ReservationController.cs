using Microsoft.AspNetCore.Mvc;
using Railway_Reservation.Models;
using Railway_Reservation.Repository;

namespace Railway_Reservation.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservation reservation;
        
        public ReservationController(IReservation reservation)
        {
            this.reservation = reservation;
        }

        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetAllReservations()
        {
            var reservations = await reservation.GetAllReservations();
            return Ok(reservations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservationById(int id)
        {
            var result = await reservation.GetReservationById(id);
            if(result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Reservation>> CancelReservationById(int id)
        {
            var result =  await reservation.CancelReservation(id);
            if(result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
