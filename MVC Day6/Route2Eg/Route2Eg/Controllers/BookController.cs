using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route2Eg.Controllers
{
   // [RoutePrefix("books")]
    public class BookController : Controller
    {
        // GET: Book
        [Route("all")]
        public ActionResult GetAllBooks()
        {
            return View();
        }

       // [Route("{id:int}")]
        public ActionResult GetBookById(int id)
        {
            return View();
        }

       // [Route("articles/{name}")]
       [Route("{bname}")]
        public ActionResult GetBookByName(string bname)
        {
            return View();

        }
        [Route("authors/{authors=Ram}")]
        public ActionResult GetBookByAuthor()
        {
            return View();

        }
    }
}