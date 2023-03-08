using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InstructorDepartment.Models;

namespace InstructorDepartment.Controllers
{
    public class InstructorController : Controller
    {
        ITIEntities context = new ITIEntities();

        // GET: Instructor
        public ActionResult Index()
        {
            ViewBag.Departments = context.Departments;
            //ins => dept_id , dept_name
            //ins_name , ins_salary , dept_name
            return View(context.Instructors.ToList());
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            ViewBag.Departments = context.Departments.ToList();

            var instructors = context.Instructors.Where(i => i.Dept_Id == id);
            
            return View(instructors);
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int id)
        {
            Instructor instructor = context.Instructors.Find(id);

            return View(instructor);
        }

        // GET: Instructor/Create
        public ActionResult Create()
        {
            ViewBag.Departments = context.Departments;
            return View();
        }

        // POST: Instructor/Create
        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            try
            {
                // TODO: Add insert logic here
                //Instructor instructor = new Instructor();
                //instructor.Ins_Id = int.Parse(collection["Ins_Id"]);
                //instructor.Ins_Name = collection["Ins_Name"];
                //instructor.Ins_Degree = collection["Ins_Degree"];
                //instructor.Salary = decimal.Parse(collection["Salary"]);
                //instructor.Dept_Id = int.Parse(collection["Dept_Id"]);

                context.Instructors.Add(instructor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = true;
                ViewBag.ErrorMessage = ex.Message;
                ViewBag.Departments = context.Departments;
                return View();
            }
        }

        // GET: Instructor/Edit/5
        public ActionResult Edit(int id)
        {
            Instructor instructor = context.Instructors.Find(id);

            ViewBag.Departments = context.Departments.ToList();

            return View(instructor);
        }

        // POST: Instructor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Instructor instructor = context.Instructors.Find(id);
                instructor.Ins_Name = collection["Ins_Name"];
                instructor.Ins_Degree = collection["Ins_Degree"];
                instructor.Salary = decimal.Parse(collection["Salary"]);
                instructor.Dept_Id = int.Parse(collection["Dept_Id"]);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            //System.FormatException: 'Input string was not in a correct format.'
            {
                return View();
            }
        }

        // GET: Instructor/Delete/5
        public ActionResult Delete(int id)
        {
            Instructor instructor = context.Instructors.Find(id);

            ViewBag.Departments = context.Departments.ToList();
            
            return View(instructor);
        }

        // POST: Instructor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Instructor instructor = context.Instructors.Find(id);
                context.Instructors.Remove(instructor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            //SqlException: The DELETE statement conflicted with the REFERENCE constraint "FK_Ins_Course_Instructor". The conflict occurred in database "ITI", table "dbo.Ins_Course", column 'Ins_Id'.The statement has been terminated.
            {
                return View();
            }
        }
    }
}
