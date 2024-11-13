namespace TruckLoadingApp.Models
{
    public class User
    {
            public int UserId { get; set; }                 // Primary Key
            public required string Name { get; set; }                // Name of the user
            public required string Email { get; set; }               // User's email address
            public List<Booking> Bookings { get; set; } = new List<Booking>(); // List of user bookings
        

    }
}
