namespace MASFlightAPI.Models
{
    public class FlightPaymentModel
    {
        public long Id { get; set; }
        public string Purpose { get; set; }
        public string Tx_ref { get; set; }  
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "NGN";
        public string Redirect_url { get; set; }
        public string Payment_options { get; set; } = "card";
        public Customer  Customer { get; set; }

        // public Customization customizations { get; set;} (optional)


    }

    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
    }

    //optional
   /*public class Customization
    {
        public string title { get; set; }
        public string description { get; set; }
        public string logo { get; set; }=""
    }*/










}
