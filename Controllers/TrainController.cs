using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Railway_Reservation.Models;
using Railway_Reservation.Repo.RailwayReservationRepository;

namespace Railway_Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly ITrain trainRepository;

        public TrainController(ITrain trainRepository)
        {
            this.trainRepository = trainRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Train>>> GetAll()
        {
            return await trainRepository.GetTrains();
        }

        [HttpGet("GetSearch")]
        public async Task<ActionResult<Train>> GetSearch(string source, string destination, DateTime departureTime)
        {
            return await trainRepository.CheckAvailability(source, destination, departureTime);
        }

        [HttpPost]
        public async Task<ActionResult<Train>> AddTrain(Train train)
        {
            var addedTrain = await trainRepository.AddTrain(train);
            //return CreatedAtAction(nameof(GetTrains), new { id = addedTrain.Id }, addedTrain);
            return Ok(addedTrain);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrain(int id)
        {
            bool passenger = await trainRepository.RemoveTrain(id);
            if (passenger)
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Train>> UpdateTrain(int id, Train train)
        {
            train = await trainRepository.UpdateTrain(id, train);
            if (train == null)
            {
                return NotFound();
            }
            return Ok(train);
        }
    }
}