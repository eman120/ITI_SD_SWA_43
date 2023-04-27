using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.BL.Dtos;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.BL.Managers
{
    public interface ITicketManager
    {
        IEnumerable<TicketReadDto> GetAll();
        public void Delete(int Id);
        public TicketReadDto GetTicket(int TicketId);
        public void AddTicket(TicketReadDto ticket);
        public void UpdateTicket(int Id, TicketReadDto ticket);
        int SaveChanges();
        void EditTicketDevelopers(EditTicketWithDevelopersReadDto editTicketWithDevelopers);
    }
}
