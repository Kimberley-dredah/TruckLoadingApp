using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TruckLoadingApp.Models;

namespace TruckLoadingApp.Data
{
    public class TruckLoadingAppContext : DbContext
    {
        public TruckLoadingAppContext (DbContextOptions<TruckLoadingAppContext> options)
            : base(options)
        {
        }

        public DbSet<TruckLoadingApp.Models.Truck> Truck { get; set; } = default!;
        public DbSet<TruckLoadingApp.Models.Route> Route { get; set; } = default!;
        public DbSet<TruckLoadingApp.Models.Booking> Booking { get; set; } = default!;
        public DbSet<TruckLoadingApp.Models.User> User { get; set; } = default!;
    }
}
