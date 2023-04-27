using CarsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using CarsApi;
using CarsApi.Validations;

namespace CarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            if(!CarList.cars.Any())
            {
                return NotFound();
            }
            _logger.LogCritical("Get All Cars");
            return CarList.cars;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Car> GetById(int id)
        {
            var car = CarList.cars.Find(c => c.Id == id);
            if(car is null)
            {
                return NotFound();
            }
            return car;
        }

        [HttpPost]
        public ActionResult AddWithoutType([FromBody] Car car)
        {
            if(car is null)
            {
                return BadRequest();
            }
            car.Id = new Random().Next(10, 100);
            car.Type = "Gas";
            //increase counter only if add is requested (this or in middleware)
            Car._requestCounter++;
            CarList.cars.Add(car);
            //return Created("", CarList.cars);
            return CreatedAtAction(
                actionName: "GEtById",
                routeValues: new { id = car.Id },
                value: new { Message = "Car has been added successfully" }
            );
        }

        [HttpPost]
        [Route("addWithType")]
        [ValidateCarType]
        public ActionResult AddWithType([FromBody] Car car)
        {
            if (car is null)
            {
                return BadRequest();
            }
            car.Id = new Random().Next(10, 100);
            //increase counter only if add is requested (this or in middleware)
            Car._requestCounter++;
            CarList.cars.Add(car);
            //return Created("", CarList.cars);
            return CreatedAtAction(
                actionName: "GEtById",
                routeValues: new { id = car.Id },
                value: new { Message = "Car has been added successfully" }
            );
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update (int id , [FromBody] Car car)
        {
            if(id != car.Id)
            {
                return BadRequest();
            }
            var c = CarList.cars.Find(c => c.Id == id);
            if(c is null)
            {
                return NotFound();
            }
            c.Name = car.Name;
            c.Model = car.Model;

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            var car = CarList.cars.Find(c => c.Id == id);
            if(car is null)
            {
                return NotFound();
            }
            CarList.cars.Remove(car);
            return NoContent();
        }

        [HttpGet("request-count")]
        public ActionResult<int> GetRequestCount()
        {
            return Car._requestCounter;
        }
    }
}
