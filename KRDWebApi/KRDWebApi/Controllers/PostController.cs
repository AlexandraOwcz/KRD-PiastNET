using KRDWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KRDWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private static List<Post> _posts = new List<Post>();
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            return Ok(new { posts = _posts});
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new { post = _posts.Where(x => x.Id == id).FirstOrDefault() });
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AddPost([FromBody]Post post)
        {
            post.Id = _posts.Count + 1;
            _posts.Add(post);
            return Ok();
        }
    }
}
