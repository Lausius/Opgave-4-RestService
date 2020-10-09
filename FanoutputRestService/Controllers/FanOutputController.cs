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
        public static List<FanOutput> fanOutputReadings = new List<FanOutput>()
        {
            new FanOutput("First Output", 15, 30),
            new FanOutput("Second Output", 18, 41),
            new FanOutput("Third Output", 24, 69),
            new FanOutput("Fourth Output", 22, 49),
            new FanOutput("Fifth Output", 20, 75),
            new FanOutput("Sixth Output", 16, 50),
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
            value.Id = FanOutput._counter++;
            fanOutputReadings.Add(value);
        }

        // PUT api/<FanOutputController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutput value)
        {
            FanOutput fanOutput = Get(id);
            if (fanOutput != null)
            {
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
