using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltersEg.Filters;

namespace FiltersEg.Controllers
{
    
    public class BikeController : Controller
    {
        // GET: Bike
      //  [Authorize(Users = "admin@gmail.com,rekha@gmail.com")]
        [CustomFilter]
        public ActionResult Index()
        {
            return View();
        }

        [LogicFilter]
        public ActionResult Show()
        {
            return View();
        }
                            
        
        [OutputCache(Duration =10, Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult Output()
        {
            ViewBag.Time = DateTime.Now.ToString();
            return View();
        }
    }
}