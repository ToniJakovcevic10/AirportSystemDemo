using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class PassengerRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public PassengerRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public List<Passenger> GetPassengers()
        {
            return _airportSystemContext.Passengers.ToList();
        }
        public void AddPassenger(Passenger passenger)
        {
            _airportSystemContext.Passengers.Add(passenger);
            _airportSystemContext.SaveChanges();
        }
        public Passenger GetPassenger(int PassengerId)
        {
            return _airportSystemContext.Passengers.FirstOrDefault( passanger => passanger.Id.Equals(PassengerId));
        }
        public void UpdatePassenger(Passenger passenger)
        {
            var passengerForUpdate=GetPassenger(passenger.Id);
            if(passengerForUpdate!=null)
            {
                passengerForUpdate.Name= passenger.Name;
                passengerForUpdate.Surname=passenger.Surname;
                passengerForUpdate.Gender=passenger.Gender;

                _airportSystemContext.SaveChanges();
            }
        }

        public void DeletePassenger(int passengerId)
        {
            var passengerForDelete = GetPassenger(passengerId);
            if (passengerForDelete!= null)
            {
                _airportSystemContext.Passengers.Remove(passengerForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
    }
}
