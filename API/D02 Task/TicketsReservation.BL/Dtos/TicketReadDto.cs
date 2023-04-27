using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation.BL.Dtos
{
    public record TicketReadDto(int Id,
        string Description , IEnumerable<DeveloperReadDto> Developers)
    {
        public TicketReadDto() : this(0, "", new List<DeveloperReadDto>())
        {
        }
    }
}
