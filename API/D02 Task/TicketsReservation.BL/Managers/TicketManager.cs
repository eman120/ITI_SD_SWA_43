using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.BL.Dtos;
using TicketsReservation.DAL.Data.Models;
using TicketsReservation.DAL.Repos;

namespace TicketsReservation.BL.Managers
{
    public class TicketManager : ITicketManager
    {
        private readonly ITicketRepo _ticketRepo;
        private readonly IDeveloperRepo _developerRepo;

        public TicketManager(ITicketRepo ticketRepo,
            IDeveloperRepo developerRepo)
        {
            _ticketRepo = ticketRepo;
            _developerRepo = developerRepo;
        }

        public IEnumerable<TicketReadDto> GetAll()
        {
            var TicketFromDB = _ticketRepo.GetAll();
            return TicketFromDB.Select(t => new TicketReadDto(Id: t.Id,
                Description: t.Description,
                Developers: t.Developers.Select(d => new DeveloperReadDto
                (
                    Id : d.Id,
                    Name: d.Name
                ))
                ));
            //should put all properties 
        }

        public void AddTicket(TicketReadDto ticket)
        {
            if (ticket == null)
            {
                return;
            }

            var newTicket = new Ticket
            {
                Description = ticket.Description
            };

            _ticketRepo.AddTicket(newTicket);
            _ticketRepo.SaveChanges();
        }

        public void Delete(int Id)
        {
            var ticket = _ticketRepo.GetTicket(Id);
            if (ticket != null)
            {
                _ticketRepo.Delete(Id);
                _ticketRepo.SaveChanges();
            }
            else
                return;
        }


        public TicketReadDto GetTicket(int Id)
        {
            var ticketFromDB = _ticketRepo.GetTicket(Id);
            if (ticketFromDB == null)
            {
                return new TicketReadDto();
            }
            return new TicketReadDto
            {
                Id = ticketFromDB.Id,
                Description = ticketFromDB.Description
            };
        }

        public int SaveChanges()
        {
            return _ticketRepo.SaveChanges();
        }

        public void UpdateTicket(int Id, TicketReadDto ticket)
        {
            var tk = _ticketRepo.GetTicket(Id);
            if (tk != null)
            {
                tk.Description = ticket.Description;
                _ticketRepo.SaveChanges();

            }
        }

        public void EditTicketDevelopers(EditTicketWithDevelopersReadDto editTktWithDev)
        {
            //Get Doctor from Repo
            Ticket? ticket = _ticketRepo.GetWithDevById(editTktWithDev.TicketId);
            //Clear Ticket Developers
            ticket?.Developers.Clear();
            //Get New Developers from Db
            ICollection<Developer> newDevelopers = _developerRepo.GetDevsByIds(editTktWithDev.DevelopersId).ToList();
            //Assign new Developers to Ticket
            ticket.Developers = newDevelopers;
            //saveChanges
            _developerRepo.SaveChanges();
        
        }
    }
}
