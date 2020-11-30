using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApi.Models;
using System.Runtime.Serialization;

namespace FirstWebApi.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> strings = new List<string> { "value0", "value1", "value2" };

        // GET: api/Demo
        public IEnumerable<string> Get()
        {
            // return new string[] { "value1", "value2" };
            return strings;
        }

        // GET: api/Demo/5
        public string Get(int id)
        {
            // return "value";
            return strings[id];
        }

       // 2. Second type to avoid null values
        [HttpPost]

        public IEnumerable<string>AddData([FromBody] Simplemodel model)
        {
            strings.Add(model.Name);
            return strings;
        }

       
            //1. first type 
        /* public IEnumerable<string> Post([FromBody]string val)
         {
             strings.Add(val);
             return strings;
         }*/

        // POST: api/Demo
        /* public void Post([FromBody]string value)
         {

         }*/

        // PUT: api/Demo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Demo/5
        public void Delete(int id)
        {
        }
    }
}
