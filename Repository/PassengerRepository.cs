using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Data;
using Railway_Reservation.Models;

namespace Railway_Reservation.Repo.RailwayReservationRepository
{
    public class PassengerRepository : IPassenger
    {
        private readonly RailwayContext railwayContext;

        public PassengerRepository(RailwayContext railwayContext)
        {
            this.railwayContext = railwayContext;
        }

        public async Task<Passenger> AddPassenger(Passenger passenger)
        {
            //throw new NotImplementedException();
            await railwayContext.Passengers.AddAsync(passenger);
            await railwayContext.SaveChangesAsync();
            return passenger;
        }

        public async Task<Passenger> DeletePassengerById(int id)
        {
            var passenger = await railwayContext.Passengers.FindAsync(id);
            if (passenger == null)
            {
                return null;
            }
            railwayContext.Passengers.Remove(passenger);
            await railwayContext.SaveChangesAsync();

            return passenger;
        }


        public async Task<List<Passenger>> GetAllPassenger()
        {
            return await railwayContext.Passengers.ToListAsync();
        }

        public async Task<Passenger> GetPassengerById(int id)
        {
            return await railwayContext.Passengers.FirstOrDefaultAsync(p => p.PassengerId == id);
        }

        public async Task<Passenger> UpdatePassenger(int id, Passenger passenger)
        {
            var pass = await railwayContext.Passengers.FindAsync(id);

            if (pass == null)
            {
                return null;
            }
            pass.PassengerId = id;
            pass.Name = passenger.Name;
            pass.EmailId = passenger.EmailId;
            pass.Password = passenger.Password;
            pass.age = passenger.age;
            pass.gender = passenger.gender;
            pass.Phone_no = passenger.Phone_no;
            await railwayContext.SaveChangesAsync();
            return pass;

        }
    }
}