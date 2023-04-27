using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsReservation.BL.Dtos
{
    public record EditTicketWithDevelopersReadDto(int TicketId, string TicketTitle , int[] DevelopersId /*, string DeveloperName*/);
}
