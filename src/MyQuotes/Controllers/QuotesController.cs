using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyQuotes.models;

namespace MyQuotes.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return new List<Quote> {
                new Quote {Id=1,Content="This is my stuff",Author="John SMith" },
                new Quote {Id=2,Content="This is my stuff",Author="Randy Anzaldua" },
                new Quote {Id=3,Content="This is my stuff",Author="Jose Radriguiz" }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
