using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRoutingEg.Models;

namespace AttributeRoutingEg.Controllers
{
    [RoutePrefix("student")]
    public class StudentController : Controller
    {
        static List<Student> stud = new List<Student>()
        {
            new Student(){Id=1, Name="Saranya"},
            new Student(){Id=2, Name="Girish"},
            new Student(){Id=3, Name="Sumesh"},
            new Student(){Id=4, Name="Shraddha"}
        };
        
        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(stud);
        }

        [HttpGet]
       // [Route("Student/{StdId=2}")]  
       [Route("{StdId}")]
        public ActionResult GetStudentById(int StdId)
        {
          Student st = stud.FirstOrDefault(s => s.Id == StdId);
            return View(st);
            //return View();
        }
        [Route("{/{sname ?}")]
       // [Route("{sname ?}")]
        public ActionResult GetStudentbyName(string sname)
        {
            ViewBag.Message = sname;
            return View();
        }
        [Route("Student/{StdId=2}")]
        public ActionResult GetStudent(int id)
        {
            ViewBag.Message = id;
            return View();
        }

        //[Route("~tech/teachers")]
       // [ActionName("Teachers")]
        public ActionResult GetTeachers()
        {
         
             List<Teacher> teacher = new List<Teacher>()
             { 
            new Teacher(){Id=1, Name="Saru"},
            new Teacher(){Id=2, Name="Giri"},
            new Teacher(){Id=3, Name="Suma"},
            new Teacher(){Id=4, Name="Shraddha"}
        };
            return View(teacher);
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}