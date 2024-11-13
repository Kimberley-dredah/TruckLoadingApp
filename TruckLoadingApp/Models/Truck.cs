namespace TruckLoadingApp.Models
{
    public class Truck
    {
            public int TruckId { get; set; }        // Primary Key
            public required string TruckNumber { get; set; } // Registration Number
            public required string DriverName { get; set; }  // Name of the truck driver
            public List<Route> Routes { get; set; } = new List<Route>(); // List of routes for this truck
        

    }
}
