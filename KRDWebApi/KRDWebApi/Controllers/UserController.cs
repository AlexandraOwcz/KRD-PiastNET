using KRDWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KRDWebApi.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        IUserRepository _userRepository;
        public UserController(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _userRepository.GetAllUsers();
                //return Ok(users);
                return View(users.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _userRepository.GetUserById(id);

                if (user == null)
                {
                    Console.WriteLine($"Owner with id: {id}, hasn't been found in list.");
                    return NotFound();
                }
                else
                {
                    Console.WriteLine($"Returned owner with id: {id}");
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
            // https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/create-a-rest-api-with-attribute-routing
        }

        [Route("create")]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateUser(User newUser)
        {
            _userRepository.AddUser(newUser);
            return StatusCode(200, $"Owner with id: {newUser.Name}, hasn't been found in list.");
            return RedirectToAction("GetAllUsers");
        }

        // GET: /Movies/Delete/5
        [Route("delete/{id:int}")]
        public ActionResult DeleteUser(int id = 0)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            User userToDelete = _userRepository.GetUserById(id);
            if (userToDelete == null)
            {
                return NotFound();
            }
            //return StatusCode(200, "Deleted");
            _userRepository.DeleteUser(id);
            return StatusCode(200, "Deleted");
        }

        [HttpDelete, ActionName("DeleteUser")]
        public IActionResult DeleteConfirmed(int id)
        {
            _userRepository.DeleteUser(id);
            //return StatusCode(200, "Deleted");
            return RedirectToAction("GetAllUser");
        }

        // GET: api/users/edit/1
        [Route("edit/{id:int}")]
        public IActionResult EditUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                Console.WriteLine($"Owner with id: {id}, hasn't been found in list.");
                return NotFound();
            }
            return View(user);
        }

        // do poprawki Edit!
        // api/users/edit/1
        [HttpPost]
        [Route("edit/{id:int}")]
        public IActionResult EditUser(int id, FormCollection formValues)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                Console.WriteLine($"Owner with id: {id}, hasn't been found in list.");
                return NotFound();
            }
            user.Name = Request.Form["Name"];
            user.Surname = Request.Form["Surname"];
            user.Street = Request.Form["Street"];
            user.Gender = Char.Parse(Request.Form["Gender"]);
            user.Country = Request.Form["Country"];
            _userRepository.EditUser(id, user);
            return RedirectToAction("GetAllUsers");
        }
    }
}
