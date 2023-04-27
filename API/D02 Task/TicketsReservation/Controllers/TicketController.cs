using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketsReservation.BL.Dtos;
using TicketsReservation.BL.Managers;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketManager _ticketManager;
        public TicketController(ITicketManager ticketManager)
        {
            _ticketManager = ticketManager;
        }

        [HttpGet]
        public ActionResult<List<TicketReadDto>> GetAll()
        { 
            return _ticketManager.GetAll().ToList();
        }

        [HttpGet("{id}")]

        public ActionResult<TicketReadDto> GetTicketById(int id)
        {
            var ticket = _ticketManager.GetTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }
        [HttpPost]
        public ActionResult<TicketReadDto> CreateTicket(TicketReadDto ticket)
        {
            _ticketManager.AddTicket(ticket);
            return CreatedAtAction(nameof(GetTicketById), new { id = ticket.Id }, ticket);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateTicket(int id, TicketReadDto ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }
            _ticketManager.UpdateTicket(id, ticket);
            return NoContent();

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteTicket(int id)
        {

            _ticketManager.Delete(id);

            return NoContent();
        }

        [HttpPost("EditTicketWithDeverlopers")]
        public ActionResult<List<TicketReadDto>> EditTicketWithDeverlopers(EditTicketWithDevelopersReadDto editTicketWithDevelopers )
        {
            _ticketManager.EditTicketDevelopers(editTicketWithDevelopers);
            return _ticketManager.GetAll().ToList();
        }
    }
}
