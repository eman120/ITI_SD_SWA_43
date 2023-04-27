using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Repos
{
    public interface ITicketRepo
    {
        IEnumerable<Ticket> GetAll();
        public void Delete(int Id);
        public Ticket GetTicket(int TicketId);
        public void AddTicket(Ticket ticket);
        public void UpdateTicket(int Id, Ticket ticket);
        int SaveChanges();
        Ticket? GetWithDevById(int ticketId);
    }
}
