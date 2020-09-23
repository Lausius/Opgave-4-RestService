using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Opgave1_Model_Klasse;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FanoutputRestService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FanOutputController : ControllerBase
    {
        public List<FanOutput> fanOutputReadings = new List<FanOutput>()
        {
            new FanOutput(1, "First Output", 15, 30),
            new FanOutput(2, "Second Output", 18, 41),
            new FanOutput(3, "Third Output", 24, 69),
            new FanOutput(4, "Fourth Output", 22, 49),
            new FanOutput(5, "Fifth Output", 20, 75),
            new FanOutput(6, "Sixth Output", 16, 50),
        };

        // GET: api/<FanOutputController>
        [HttpGet]
        public IEnumerable<FanOutput> Get()
        {
            return fanOutputReadings;
        }

        // GET api/<FanOutputController>/5
        [HttpGet("{id}")]
        public FanOutput Get(int id)
        {
            return fanOutputReadings.Find(i => i.Id == id);
        }

        // POST api/<FanOutputController>
        [HttpPost]
        public void Post([FromBody] FanOutput value)
        {
            fanOutputReadings.Add(value);
        }

        // PUT api/<FanOutputController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutput value)
        {
            FanOutput fanOutput = Get(id);
            if (fanOutput != null)
            {
                fanOutput.Id = value.Id;
                fanOutput.Name = value.Name;
                fanOutput.Temperature = value.Temperature;
                fanOutput.Humidity = value.Humidity;
            }
        }

        // DELETE api/<FanOutputController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FanOutput fanOutput = Get(id);
            fanOutputReadings.Remove(fanOutput);
        }
    }
}
