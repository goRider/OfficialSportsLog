using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackSportsLog.Data;
using FullStackSportsLog.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackSportsLog.Controllers
{
    [Route("api/[controller]")]
    public class AdminUserController : Controller
    {
        private readonly SportsContext _sportsContext;

        public AdminUserController(SportsContext sportsContext)
        {
            _sportsContext = sportsContext;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<List<AdminUser>> Get()
        {
            var admins = _sportsContext.AdminUsers.ToList();
            return admins;
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
