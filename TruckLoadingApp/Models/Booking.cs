namespace TruckLoadingApp.Models
{
    public class Booking
    {
            public int BookingId { get; set; }              // Primary Key
            public int RouteId { get; set; }                // Foreign key to Route
            public required Route Route { get; set; }                // Associated Route
            public int UserId { get; set; }                 // Foreign key to User
            public required User User { get; set; }                  // Associated User
            public decimal Cost { get; set; }               // Cost of booking
            public bool IsPaid { get; set; }                // Payment status
        

    }
}
