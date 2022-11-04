using MASFlightAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MASFlightAPI.Repositories
{
    public class MASFlightRepository : IMASFlightInterface
    {
        private MASFlightDbContext _masFlightDbContext;

        public MASFlightRepository(MASFlightDbContext masFlightDbContext)
        {
            _masFlightDbContext = masFlightDbContext;
        }
        public ResponseModel DeleteMASFlight(long BookingId)
        {
            var response = new ResponseModel();
            var bookingId = GetMASFlights(BookingId);
            if(bookingId != null)
            {
                
                _masFlightDbContext.Remove(bookingId);
                _masFlightDbContext.SaveChanges();

                response.Success = true;
                response.Error = "Ticket successfully deleted, you can book ";

            }
            else
            {
                response.Success = false;
                response.Error = "Ticket Id cannot be found";
            }
           return response;
        }

      

        public MASFlightBooking GetMASFlights(long BookingId)
        {
 
            var ticketExist = _masFlightDbContext.Set<MASFlightBooking>().FirstOrDefault(t=>t.BookingId==BookingId);
           

            return ticketExist;
        }

        public List<MASFlightBooking> GetMASFlights()
        {
            var ticketExist = _masFlightDbContext.Set<MASFlightBooking>().ToList();
            return ticketExist;
        }

        public ResponseModel SaveMASFlight(MASFlightBooking masflight)
        {
            var response = new ResponseModel();
            
            var existUser = _masFlightDbContext.Set<MASFlightBooking>().Where(t=>t.TicketName==masflight.TicketName&&
                                                                            t.TicketDescription==masflight.TicketDescription&&
                                                                            t.departure==masflight.departure&&
                                                                            t.destination==masflight.destination&&
                                                                            t.location==masflight.location&&
                                                                            t.Trip_Type==masflight.Trip_Type&&
                                                                            t.Age==masflight.Age&&
                                                                            t.UserId==masflight.UserId).ToList();

            if (existUser.Count > 0)
            {
                response.Success=false;
                response.Error = "User with the same Ticket details exist";
            }
            else
            {
                _masFlightDbContext.Add(masflight);
                _masFlightDbContext.SaveChanges();

                response.Success=true;
                response.Error = "Flight successfully booked";

                
            }

            return response;
        }

        

        public ResponseModel UpdateMASFlight(MASFlightBooking masflight)
        {
            var response = new ResponseModel();
            var existUser = _masFlightDbContext.Set<MASFlightBooking>().Where(t => t.UserId==masflight.UserId).ToList();
            //if userId exist flight details will be updated 
            if (existUser!=null)
            {
                _masFlightDbContext.Update(masflight);
                _masFlightDbContext.SaveChanges();

                response.Success= true;
                response.Error = "Flight details updated";

            }
            else
            {
                response.Success= false;
                response.Error = "User not found ,kindly create a flight details";
            }
            return response;
            
        }
    }
}
