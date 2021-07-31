using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBusTransportation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineBusTransportation.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Buses> Buses { get; set; }

        public DbSet<BusInfo> BusInfo { get; set; }
        public DbSet<UsersBooking> UsersBooking { get; set; }
        public DbSet<StaffViewModel> StaffViewModel { get; set; }

        public DbSet<Departure> Departure { get; set; }
        public DbSet<Destination> Destination { get; set; }


    }
}
