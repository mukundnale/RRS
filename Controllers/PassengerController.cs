using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.DTO;
using Railway_Reservation.Models;
using Railway_Reservation.Repo.RailwayReservationRepository;

namespace Railway_Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassenger Ipassenger;

        public PassengerController(IPassenger Ipassenger)
        {
            this.Ipassenger = Ipassenger;
        }

        // GET: api/Passenger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passenger>>> GetPassengers()
        {
            return await Ipassenger.GetAllPassenger();
        }

        // GET: api/Passenger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passenger>> GetPassenger(int id)
        {

            return await Ipassenger.GetPassengerById(id);
        }

        // PUT: api/Passenger/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassenger(int id, PassengerDTO passengerdto)
        {
            var passenger = new Passenger();
            passenger.Name = passengerdto.Name;
            passenger.EmailId = passengerdto.EmailId;
            passenger.Password = passengerdto.Password;
            passenger.Phone_no = passengerdto.Phone_no;
            passenger.age = passengerdto.age;
            passenger.gender = passengerdto.gender;
            passenger.UserId = passengerdto.UserId;

            passenger = await Ipassenger.UpdatePassenger(id, passenger);
            if(passenger==null)
            {
                return NotFound();
            }
            else
            {
                passenger.Name = passengerdto.Name;
                passenger.EmailId = passengerdto.EmailId;
                passenger.Password = passengerdto.Password;
                passenger.Phone_no = passengerdto.Phone_no;
                passenger.age = passengerdto.age;
                passenger.gender = passengerdto.gender;
                passenger.UserId = passengerdto.UserId;
            }
            return NoContent();
        }

        // POST: api/Passenger
     
        [HttpPost]
        public async Task<ActionResult<Passenger>> PostPassenger(PassengerDTO passengerdto)
        {
            var passenger = new Passenger();
            passenger.Name = passengerdto.Name;
            passenger.EmailId = passengerdto.EmailId;
            passenger.Password = passengerdto.Password;
            passenger.Phone_no = passengerdto.Phone_no;
            passenger.age = passengerdto.age;
            passenger.gender = passengerdto.gender;
            passenger.UserId = passengerdto.UserId;

            await Ipassenger.AddPassenger(passenger);


            return Ok(passenger);
        }

        // DELETE: api/Passenger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassenger(int id)
        {
            var passenger = await Ipassenger.DeletePassengerById(id);

            if (passenger != null)
            {
                return Ok(passenger);
            }


            return NotFound();
        }



    }
}