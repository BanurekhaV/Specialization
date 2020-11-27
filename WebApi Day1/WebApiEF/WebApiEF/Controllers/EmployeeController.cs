using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEF.Models;

namespace WebApiEF.Controllers
{
    public class EmployeeController : ApiController
    {
        dbStudyEntities db = new dbStudyEntities();
        [Route("Getemployees")]
        //GET
        public HttpResponseMessage Get()
        {
            var emp = db.tblEmployees.ToList();
            if(emp.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No Data Found");
            }
        }
        [Route("Gender")]
        //GET by Gender
        public HttpResponseMessage Get(string Gender="All")
        {
            switch (Gender.ToLower())
            {
                case "all":
                    return Request.CreateResponse(HttpStatusCode.OK, db.tblEmployees.ToList());
                case "male":
                    return Request.CreateResponse(HttpStatusCode.OK, 
                        db.tblEmployees.Where(e => e.Gender.ToLower() == "male").ToList());
                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        db.tblEmployees.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest,
                       "Value for Gender must be either Male or Female");
            }

        }
    }
}
