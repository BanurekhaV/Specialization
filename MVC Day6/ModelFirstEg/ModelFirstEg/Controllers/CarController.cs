using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirstEg.Controllers
{
    public class CarController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Car
        public ActionResult Index()
        {
            return View(db.cars.ToList());
        }
    }
}