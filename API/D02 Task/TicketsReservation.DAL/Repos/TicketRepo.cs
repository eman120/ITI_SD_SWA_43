using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Context;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Repos
{
    public class TicketRepo : ITicketRepo
    {
        //private TicketReservationContext _context { get; }
        private readonly TicketReservationContext _context;
        public TicketRepo(TicketReservationContext context)
        {
            _context = context;
        }
        public IEnumerable<Ticket> GetAll()
        {
            if (_context.tickets != null)
            {
                return _context.Set<Ticket>().Include(d => d.Developers);

            }
            else
                return Enumerable.Empty<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            if (ticket != null)
            {
                _context.tickets.Add(ticket);
                _context.SaveChanges();
            }
            else return;
        }

        public void Delete(int Id)
        {
            var ticket = _context.tickets.Find(Id);
            if (ticket != null)
            {
                _context.tickets.Remove(ticket);
                _context.SaveChanges();
            }
            else
                return;
        }


        public Ticket GetTicket(int TicketId)
        {
            return _context.tickets.Find(TicketId) ?? new Ticket();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdateTicket(int Id, Ticket ticket)
        {
            var tk = _context.tickets.Find(Id);
            if (tk != null)
            {

                tk.Title = ticket.Title;
                tk.Description = ticket.Description;
                _context.SaveChanges();

            }
        }

        public Ticket? GetWithDevById(int ticketId)
        {
            return _context.tickets.Include(t => t.Developers).FirstOrDefault(t => t.Id == ticketId) ?? new Ticket();
        }
    }
}
