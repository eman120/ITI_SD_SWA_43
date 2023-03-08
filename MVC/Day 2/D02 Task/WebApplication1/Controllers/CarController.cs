using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult GetAllCars()
        {
            List<Car> carList = CarList.Cars;

            ViewBag.Cars = carList; 
            return View();
        }

        //Get car by Id
        public ActionResult SelectCarById(int id)
        {
            //Car car = CarList.Cars[id];

            ///First Way
            //Car car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            //ViewBag.SelectedCar = car;

            ///second Way
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(c => c.Num == id);

            return View();
        }

        public ActionResult CreateNewCar()
        {
            //Car car = CarList.Cars[id];

            ///First Way
            //Car car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            //ViewBag.SelectedCar = car;

            ///second Way
            //ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(c => c.Num == id);

            //ViewBag.NewCar = new Car();
            return View();
        }

        //Save New Car
        public ActionResult SaveNewCar(int id, string Color, string Model, string Manfacture)
        {
            Car car = new Car();
            car.Num = id;
            car.Color = Color;
            car.Model = Model;
            car.Manfacture = Manfacture;
            CarList.Cars.Add(car);

            return RedirectToAction("GetAllCars");
        }

        //Edit Car
        public ActionResult UpdateCar(int id)
        {
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(c => c.Num == id);

            return View();
        }

        //Save Edited Car
        ///name it UpdateCar as the previous one, but add [httpPost] before it 
        public ActionResult SaveUpdateCar(int id ,string Color, string Model, string Manfacture)
        {
            Car car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            car.Color = Color;
            car.Model = Model;
            car.Manfacture = Manfacture;

            return RedirectToAction("GetAllCars");
        }

        //Delete Car
        public ActionResult DeleteCar(int id)
        {
            var deletedCar = CarList.Cars.FirstOrDefault(c => c.Num == id);
            CarList.Cars.Remove(deletedCar);

            return RedirectToAction("GetAllCars");
            //return View();
        }
    }
}