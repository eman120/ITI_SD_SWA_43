using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketsReservation.BL.Dtos;
using TicketsReservation.BL.Managers;
using TicketsReservation.DAL.Data.Context;
using TicketsReservation.DAL.Data.Models;

namespace TicketsReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager;
        public DepartmentController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        [HttpGet]
        public ActionResult<List<DepartmentReadDto>> GetAll()
        {
            return _departmentManager.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<List<DepartmentReadDto>> GetbById(int id)
        {
            DepartmentReadDto? department = _departmentManager.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

    }
}
