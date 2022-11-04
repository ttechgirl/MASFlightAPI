using MASFlightAPI.Models;
using MASFlightAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MASFlightAPI.Controllers
{
    public class MASFlightController :ControllerBase
    {
        private readonly IMASFlightInterface _masFlightInterface;

        public MASFlightController(IMASFlightInterface masFlightInterface)
        {
            _masFlightInterface = masFlightInterface;
        }
        [HttpGet("masFlightbookings")] //readonly i.e retrieiving list of all flight bookings from the database
        public IActionResult GetMASFlights()
        {
            var masFlightbookings = _masFlightInterface.GetMASFlights();
            if(masFlightbookings == null)
            {
                return NotFound();

           
            }
          return Ok(masFlightbookings);
        
        }
       [HttpPost("createFlight")]

       //user will be able to create/book ticket and save changes
      public IActionResult SaveFlightBookings(MASFlightBooking masflight)
      {
            //if (!ModelState.IsValid) {return BadRequest(ModelState);}
            var createFlight= _masFlightInterface.SaveMASFlight(masflight);
            if(createFlight.Success==true)
            {
                return Ok(createFlight);
            }
            return BadRequest();
      }
      [HttpDelete("{bookingId}")] 
        public IActionResult DeleteMASFlight(long BookingId)
        {
            var bookingId = _masFlightInterface.DeleteMASFlight(BookingId);
            if (bookingId.Success == true)
            {
                return Ok(bookingId);

            }
              return NotFound();
        
        }
        [HttpPut("existId")]
        public IActionResult UpdateMASFlight(MASFlightBooking masflight)
        {
            var existId=_masFlightInterface.UpdateMASFlight(masflight);
            if (existId.Success == true) 
            { 
                return Ok(existId); 
            }
            return BadRequest();
        }
    }
}

