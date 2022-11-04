namespace MASFlightAPI.Models
{
    public class MASFlightAdmin
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Trip_Type RoundTrip{ get; set; }
        public Trip_Type OneWay { get; set; }

    }
}
