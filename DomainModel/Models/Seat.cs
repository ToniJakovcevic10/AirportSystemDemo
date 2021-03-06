using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }

        public string? SeatNumber { get; set; }

        public Passenger Passenger { get; set; }

        public Flight Flight { get; set; }
    }
}
