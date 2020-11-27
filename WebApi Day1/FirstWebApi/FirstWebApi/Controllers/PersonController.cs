using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApi.Models;

namespace FirstWebApi.Controllers
{
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1, Name="Rohan",City="Hyderabad"},
            new Person{Id=2, Name="Sudha",City="Chennai"},
            new Person{Id=3, Name="Guru",City="Bangalore"},
            new Person{Id=4, Name="Vikram",City="Bombay"},
        };
        //GET
        [Route("persondetails")]
        public IEnumerable<Person>Get()
        {
            return personlist;
        }

        //GET with Httpresponse return type

        [Route("Personlist")]
        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
            return response;
        }

        //GET 
        //by Id
        //api/person/id
        public IHttpActionResult GetPerson(int id)
        {
            Person person = personlist.Find(p => p.Id == id);
            return Ok(person);
        }

        //POST 
        //api/person
        //From Body
       /* public void Post([FromBody]Person person)
        {
            personlist.Add(person);
           
        }*/
       //POST  api/person
       //FromURI
       public void Post([FromUri]int Id,string Name,string City)
        {
            Person p = new Person();
            p.Id = Id;
            p.Name = Name;
            p.City = City;
            personlist.Add(p);

        }

        //Update/Edit
        //PUT  api/person/4
        public void Put(int id,[FromBody]Person person)
        {
                      //because personlist is a collection
            personlist[id-1] = person;
        }

        //DELETE api/person/4

        public void Delete(int id)
        {
            personlist.RemoveAt(id-1);
        }
    }
}
