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
        private readonly ITrainRepository trainRepository;

        public TrainController(ITrainRepository trainRepository)
        {
            this.trainRepository = trainRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Train>>> GetAll()
        {
            return await trainRepository.GetTrains();
        }

        [HttpGet("{Source}")]
        public async Task<ActionResult<Train>> GetSearch(string source, string destination, DateTime departureTime)
        {
            return await trainRepository.CheckAvailability(source, destination, departureTime);
        }
    }
}