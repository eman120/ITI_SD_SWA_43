using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsReservation.BL.Dtos;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.BL.Managers
{
    public interface IDepartmentManager
    {
        IEnumerable<DepartmentReadDto> GetAll();
        DepartmentReadDto GetById(int Id);
    }
}
