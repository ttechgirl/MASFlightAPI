using System;

namespace MASFlightAPI.Models
{
    public class MASFlightBooking
    {
        public long Id { get; set; }
        public long BookingId { get; set;}
        public string TicketName { get; set; }
        public string TicketDescription { get; set; }
        public string departure { get; set; }
        public string destination { get; set; }
        public DateTime dateTime { get; set; }= DateTime.Now;
        public Location location { get; set; }
        public FlightCategories flightCategories { get; set; }
        public TravelerAge Age { get; set; } 
        public string UserId { get; set; }
        public Trip_Type Trip_Type { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string PaymentStatus { get; set; }
        
    }

    
    public enum Trip_Type
    {
        RoundTrip,
        OneWay
    }
    
    public enum FlightCategories
    {
        Economy,
        Premium,
        FirstClass,
        Business
    }


}

