using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRDWebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace KRDWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserApiController : Controller
    {
        private readonly DatabaseContext _context;
        public UserApiController(DatabaseContext context)
        {
            _context = context;
            if (_context.Users.Count() == 0)
            {
                _context.Users.Add(
                    new User
                    {
                        Name = "Bolek",
                        Surname = "Wałęsa",
                        Street = "Kwiatkowskiego 6",
                        Gender = "M",
                        Country = "Poland"
                    }
                );
                _context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {
            return Content(_context.Users.ToList().ToString());
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(int id)
        {
            var item = _context.Users.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtRoute("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            user.Name = item.Name;
            user.Surname = item.Surname;
            user.Street = item.Street;
            user.Gender = item.Gender;
            user.Country = item.Country;

            _context.Users.Update(user);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
