using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.DAL.Repos
{
    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetAll();
        Department GetById(int Id);
        int SaveChanges();
    }
}
