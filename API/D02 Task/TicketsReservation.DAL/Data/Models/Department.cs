﻿namespace TicketsReservation.DAL.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
