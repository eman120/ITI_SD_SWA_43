using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Data.Context
{
    public class TicketReservationContext : DbContext
    {
        public DbSet<Ticket> tickets => Set<Ticket>();
        public DbSet<Developer> developers => Set<Developer>();
        public DbSet<Department> departments => Set<Department>();

        public TicketReservationContext(DbContextOptions<TicketReservationContext> options) 
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
