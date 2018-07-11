using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace euth_api
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        [Produces("application/json")] // force to accept only a particular method
        public IEnumerable<string> Get()
        {
            return new string[] {"value", "value", "value3"};
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, string query)
        {
            Console.WriteLine(id);
            // return Ok(new Ten{Id=id, Text=query});
            return Ok(new Value{ Id = id, Text = "value" + query});
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody]Value value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // save the value to the DB
            return CreatedAtAction("Get", new { id = value.Id}, value);
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

    
    }

    public class Value
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string Text { get; set; }
    }

    public class Ten
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
