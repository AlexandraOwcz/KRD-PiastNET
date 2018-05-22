using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRDWebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace KRDWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PackageController : Controller
    {
        private readonly DatabaseContext _context;
        public PackageController(DatabaseContext context)
        {
            _context = context;
            if (_context.Packages.Count() == 0)
            {
                _context.Packages.Add(
                    new Package
                    {
                        Status = "dostarczono",
                        Hour = "12 AM"
                    }
                );
                /*
                    new Package
                    {
                        Status = "w drodze",
                        Hour = "6 PM"
                    },
                    new Package
                    {
                        Status = "w magazynie",
                        Hour = "6 PM"
                    },
                    new Package
                    {
                        Status = "w systemie",
                        Hour = "3 PM"
                    }
                 */
                _context.SaveChanges();
            }
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
