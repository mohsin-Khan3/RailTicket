using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace RailTicket.Models.Data
{
    public class RailDbContext:DbContext
    {
        public RailDbContext(DbContextOptions<RailDbContext> options) : base(options)
        {
        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<User_Registration> User_Registrations { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<TicketBooking> TicketBookings { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}
