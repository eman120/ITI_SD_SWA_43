using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.BL.Dtos
{
    public record TicketWithDevReadDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        //public IEnumerable<Developer> Developers { get; set; } = new List<Developer>(); /*Enumerable.Empty<TicketReadDto>()*/
        public int DevCount { get; set; }

    }
}
