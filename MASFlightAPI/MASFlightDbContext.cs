using MASFlightAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MASFlightAPI
{
    public class MASFlightDbContext :DbContext 
    {
       public MASFlightDbContext(DbContextOptions options) : base(options)
       {

       }
        DbSet<MASFlightBooking> MASFlights { get; set; } 
        DbSet<Location> Location { get; set; }
        DbSet<TravelerAge> TravelerAges { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<FlightPaymentModel> flightPayments { get; set; }
        DbSet<MASFlightAdmin> MASFlightAdmins { get; set; }


    }
}