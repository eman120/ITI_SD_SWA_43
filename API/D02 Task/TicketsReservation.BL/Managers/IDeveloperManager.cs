using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.BL.Dtos;

namespace TicketsReservation.BL.Managers
{
    public interface IDeveloperManager
    {
        IEnumerable<DeveloperReadDto> GetAll();
        public void Delete(int Id);
        public DeveloperReadDto GetTicket(int DeveloperId);
        public void AddTicket(DeveloperReadDto developer);
        public void UpdateTicket(int Id, DeveloperReadDto developer);
        int SaveChanges();
    }
}
