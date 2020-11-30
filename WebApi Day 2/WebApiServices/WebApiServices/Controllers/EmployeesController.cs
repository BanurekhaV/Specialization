using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiServices.Models;

namespace WebApiServices.Controllers
{
    public class EmployeesController : ApiController
    {
        private dbStudyEntities db = new dbStudyEntities();

        // GET: api/Employees
        public IQueryable<tblEmployee> GettblEmployees()
        {
            return db.tblEmployees;
        }

        // GET: api/Employees/5
       /* [ResponseType(typeof(tblEmployee))]
        public IHttpActionResult GettblEmployee(int id)
        {
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            if (tblEmployee == null)
            {
                return NotFound();
            }

            return Ok(tblEmployee);
        }*/

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblEmployee(int id, tblEmployee tblEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblEmployee.ID)
            {
                return BadRequest();
            }

            db.Entry(tblEmployee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblEmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(tblEmployee))]
        public IHttpActionResult PosttblEmployee(tblEmployee tblEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblEmployees.Add(tblEmployee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblEmployee.ID }, tblEmployee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(tblEmployee))]
        public IHttpActionResult DeletetblEmployee(int id)
        {
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            if (tblEmployee == null)
            {
                return NotFound();
            }

            db.tblEmployees.Remove(tblEmployee);
            db.SaveChanges();

            return Ok(tblEmployee);
        }

       // [HttpPost]
        //api/employees/id
      //  [Route("Tax/{id}")]
        public HttpResponseMessage GetTax([FromUri]int? id)
        {
            double tax = 0;


            var emp = db.tblEmployees.Find(id);

            if (emp != null)
            {
                dynamic salary = db.tblEmployees.Find(id).Salary;



                if (salary > 0)
                {
                    if ((salary * 12) > 30000)
                    {
                        tax = (salary * 12) / 10;

                    }
                    else
                    {
                        tax = 0;

                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, tax);
            }


            else
            {
                string message = "Employee with " + id.ToString() + " Doesnot  exist";
                //  return Request.CreateResponse(HttpStatusCode.OK,message);
                return Request.CreateResponse(HttpStatusCode.BadRequest, message);
            }

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblEmployeeExists(int id)
        {
            return db.tblEmployees.Count(e => e.ID == id) > 0;
        }
    }
}