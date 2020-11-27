using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltersEg.Filters;

namespace FiltersEg.Controllers
{
    [Authorize]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
       [HandleError(ExceptionType =typeof(DivideByZeroException),View ="CustomError")]
      // [LogicFilter]
      //[HandleError]
        public ActionResult CustError()
        {
            int n1 = 0, n2 = 10, n3 = 0;
            n3 = n2 / n1;
            return View();
        }

        [AllowAnonymous] // bypassing the authorization for the below method
        public ActionResult Check()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Fruits()
        {
            string[] fruits = { "Mango", "Orange" };
            ViewBag.fruit = fruits[2];
            return View();
        }
    }
}