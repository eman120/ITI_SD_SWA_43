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
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepo _departmentRepo;
        public DepartmentManager(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }


        public IEnumerable<DepartmentReadDto> GetAll()
        {
            var departmentsFromDB = _departmentRepo.GetAll();
            return departmentsFromDB.Select(d => new DepartmentReadDto(
                Id: d.Id,
                Name: d.Name,
                Tickets: d.Tickets.Select(t => new TicketWithDevReadDto
                {
                    Id = t.Id,
                    Description = t.Description,
                    DevCount = t.Developers.Count
                })
            ));
            //should put all properties which in DepartmentReadDto
        }

        public DepartmentReadDto? GetById(int Id)
        {
            var DepartmentFromDB = _departmentRepo.GetById(Id);
            if(DepartmentFromDB == null)
            {
                return null;
            }
            return new DepartmentReadDto
            {
                Id = DepartmentFromDB.Id,
                Name = DepartmentFromDB.Name,
                Tickets = DepartmentFromDB.Tickets.Select(
                    t => new TicketWithDevReadDto
                    {
                        Id = t.Id,
                        Description = t.Description,
                        DevCount = t.Developers.Count
                    })
            };
        }
    }
}
