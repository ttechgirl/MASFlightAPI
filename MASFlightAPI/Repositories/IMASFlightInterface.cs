using MASFlightAPI.Models;

using System.Collections.Generic;

namespace MASFlightAPI.Repositories
{
    public interface IMASFlightInterface
    {
        List<MASFlightBooking> GetMASFlights();
        MASFlightBooking GetMASFlights(long BookingId);
        ResponseModel SaveMASFlight(MASFlightBooking masflight);

        ResponseModel DeleteMASFlight(long BookingId);

        ResponseModel UpdateMASFlight (MASFlightBooking masflight);




    }
}
