namespace TruckLoadingApp.Models
{
    public class Route
    {
            public int RouteId { get; set; }                // Primary Key
            public required string StartLocation { get; set; }       // Start location of the route
            public required string EndLocation { get; set; }         // Destination of the route
            public required DateTime DepartureTime { get; set; }     // Departure date and time
            public required DateTime ArrivalTime { get; set; }       // Arrival date and time
            public required Truck Truck { get; set; }                // Associated truck for this route
            public int TruckId { get; set; }                // Foreign key for Truck
        

    }
}
