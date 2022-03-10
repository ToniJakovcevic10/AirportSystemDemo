using DomainModel.Models;
using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly SeatRepository _seatRepository;
        public SeatController(SeatRepository seatRepository)
        {
            _seatRepository = seatRepository;
        }
        
        [HttpGet("{flightId:int}")]
        public IActionResult GetSeats(int flightId)
        {
            try
            {
                var seats = _seatRepository.GetSeats(flightId); 
                return Ok(seats);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult AddSeat([FromBody] Seat seat)
        {
            if (seat == null)
                return BadRequest();

            try
            {
                _seatRepository.AddSeat(seat);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{flightId:int}/{seatId:int}")]
        public IActionResult GetSeatAsync(int flightId, int seatId)
        {
            try
            {
                return Ok(_seatRepository.GetSeat(seatId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{seatNumber}/{FlightId:int}")]
        public IActionResult isSeatNumberAvailable(string seatNumber, int FlightId)
        {
            try
            {
                var seat = _seatRepository.isSeatNumberAvailable(seatNumber,FlightId);
                if (seat == null)
                    return Ok(null);
                else
                return Ok(seat);
            }
            catch(System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public IActionResult UpdateSeat([FromBody] Seat seat)
        {
            try
            {
                _seatRepository.UpdateSeat(seat);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{seatId:int}")]
        public IActionResult DeleteSeat(int seatId)
        {
            try
            {
                _seatRepository.DeleteSeat(seatId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
