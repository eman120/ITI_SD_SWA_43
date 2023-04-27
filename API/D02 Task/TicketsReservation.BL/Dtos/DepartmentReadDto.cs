using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.BL.Dtos
{
    //public record DepartmentReadDto
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public IEnumerable<TicketWithDevReadDto> Tickets { get; set; } = new List<TicketWithDevReadDto>(); /*Enumerable.Empty<TicketReadDto>()*/


    //    //public DepartmentReadDto(string Name, int Id , List<TicketWithDevReadDto> Tickets)
    //    //{
    //    //    this.Id = Id;
    //    //    this.Name = Name;
    //    //    this.Tickets = Tickets;
    //    //}

    //}
    public record DepartmentReadDto(int Id, string Name, IEnumerable<TicketWithDevReadDto> Tickets)
    {
        public DepartmentReadDto() : this(0, "", new List<TicketWithDevReadDto>())
        {
        }
    }
}
