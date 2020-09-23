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
        // GET: api/<FanOutputController>
        [HttpGet]
        public IEnumerable<FanOutput> Get()
        {
            return FanOutput.fanOutputReadings;
        }

        // GET api/<FanOutputController>/5
        [HttpGet("{id}")]
        public FanOutput Get(int id)
        {
            return FanOutput.fanOutputReadings.Find(i => i.Id == id);
        }

        // POST api/<FanOutputController>
        [HttpPost]
        public void Post([FromBody] FanOutput value)
        {
            FanOutput.fanOutputReadings.Add(value);
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
            FanOutput.fanOutputReadings.Remove(fanOutput);
        }
    }
}
