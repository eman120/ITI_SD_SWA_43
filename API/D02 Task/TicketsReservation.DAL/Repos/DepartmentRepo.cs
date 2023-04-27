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
    public class DepartmentRepo :IDepartmentRepo
    {
        private readonly TicketReservationContext _context;
        public DepartmentRepo(TicketReservationContext context)
        {
            _context = context;
        }


        public IEnumerable<Department> GetAll()
        {
            return _context.Set<Department>().Include(d => d.Tickets).ThenInclude(t => t.Developers);
        }

        public Department GetById(int Id)
        {
            Department department = _context.departments.Include(d => d.Tickets).ThenInclude(t => t.Developers).FirstOrDefault(d => d.Id == Id); /*?? new Department();*/
            return department;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
