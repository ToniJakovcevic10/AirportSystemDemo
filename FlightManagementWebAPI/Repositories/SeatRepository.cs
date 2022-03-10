using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class SeatRepository
    {
        private readonly AirportSystemContext _airportSystemContext;

        public SeatRepository(AirportSystemContext airportSystemContext)
        {
                    _airportSystemContext = airportSystemContext;
        }
        public List<Seat> GetSeats(int flightId)
        {
            return _airportSystemContext.Seats.Include(seat => seat.Flight).Include(seat =>seat.Passenger).Where(seat => seat.FlightId == flightId).ToList();
        }

        public void AddSeat(Seat seat)
        {
            _airportSystemContext.Seats.Add(seat);
            _airportSystemContext.SaveChanges();
        }
        public Seat GetSeat(int SeatId)
        {
            return _airportSystemContext.Seats.FirstOrDefault(seat => seat.Id.Equals(SeatId));
        }
        public void UpdateSeat(Seat seat)
        {
            var seatForUpdate = GetSeat(seat.Id);
            if (seatForUpdate != null)
            {
                seatForUpdate.Id = seat.Id;
                seatForUpdate.PassengerId = seat.PassengerId;
                seatForUpdate.FlightId = seat.FlightId;
                seatForUpdate.SeatNumber=seat.SeatNumber;
                _airportSystemContext.SaveChanges();
            }
        }
        public Seat isSeatNumberAvailable(string seatNumber, int FlightId)
        {

            var seat = _airportSystemContext.Seats.FirstOrDefault(seat => seat.SeatNumber.Equals(seatNumber) && seat.FlightId.Equals(FlightId));
            //var seat = _airportSystemContext.Seats.
            //return _airportSystemContext.Seats.Include(seat => seat.Flight).Include(seat => seat.Passenger).Where(seat => seat.FlightId == flightId).ToList();
            if (seat == null)
                return null;
            return seat;
        }
        public void DeleteSeat(int seatId)
        {
            var seatForDelete = GetSeat(seatId);
            if (seatForDelete != null)
            {
                _airportSystemContext.Seats.Remove(seatForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
    }
}
