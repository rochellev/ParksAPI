using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParksAPIContext _db = new ParksAPIContext();

        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get()
        {
            return _db.Parks.ToList();
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(x => x.ParkId == id);
        }

    }
}