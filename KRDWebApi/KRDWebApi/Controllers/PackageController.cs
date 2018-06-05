using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRDWebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace KRDWebApi.Controllers
{
    [Route("api/PackageController")]
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
                _context.SaveChanges();
            }
        }

        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            // zrób serwisy do tego 
            return Content(_context.Packages.ToList().ToString());
        }
        
        [HttpGet("{id}", Name = "GetPackage")]
        public IActionResult GetById(int id)
        {
            var item = _context.Packages.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("AddPackage")]
        public IActionResult Post([FromBody] Package item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Packages.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetPackage", new { id = item.Id }, item);
        }
        
        [HttpPut("Update/{id:int}")]
        public IActionResult Put(int id, [FromBody] Package item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var package = _context.Packages.Find(id);
            if (package == null)
            {
                return NotFound();
            }

            package.Status = item.Status;
            package.Hour = item.Hour;

            _context.Packages.Update(package);
            _context.SaveChanges();
            return NoContent();
        }
        
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var package = _context.Packages.Find(id);
            if (package == null)
            {
                return NotFound();
            }

            _context.Packages.Remove(package);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
