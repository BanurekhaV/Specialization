using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewsEg.Models;

namespace PartialViewsEg.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View(new Student()
            {
                st = Bangaloredetails()
            });
        }
        public ActionResult ChennaiIndex()
        {
            return View(new Student()
            {
                st = Chennaidetails()
            });
        }
        public ActionResult MumbaiIndex()
        {
            return View(new Student()
            {
                st = Mumbaidetails()
            });
        }

        public List<Student> Bangaloredetails()
        {
            List<Student> model = new List<Student>();
            model.Add(new Student { Name = "Vandana", Marks = 78, Stream = "Commerce" });
            model.Add(new Student { Name = "Sanjana", Marks = 88, Stream = "Science" });
            model.Add(new Student { Name = "Rahul", Marks = 80, Stream = "Computers" });
            return model;  
        }

        public List<Student> Mumbaidetails()
        {
            List<Student> model = new List<Student>();
            model.Add(new Student { Name=" Varun", Marks = 78, Stream = "Physics" });
            model.Add(new Student { Name = "Suraj", Marks = 88, Stream = "Maths" });
            model.Add(new Student { Name = "SaiPriya", Marks = 80, Stream = "Humanities" });
            return model;
        }

        public List<Student> Chennaidetails()
        {
            List<Student> model = new List<Student>();
            model.Add(new Student { Name = "Rakshita", Marks = 78, Stream = "Economics" });
            model.Add(new Student { Name = "Sharada", Marks = 80, Stream = "Life-Science" });
            model.Add(new Student { Name = "Ranjith", Marks = 80, Stream = "Sociology" });
            return model;
        }



    }
}