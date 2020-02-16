using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPIPractice.Data;
using CoreAPIPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDAL Dal;

        public ValuesController(IDAL dAL)
        {
            Dal = dAL;
        }

        // GET api/values
        [HttpGet]
        public async Task<WeatherServiceResponse>Get(string coordinates)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("coordinates",coordinates);
            var response = await Dal.Get<WeatherServiceResponse>(parameters);
            return response;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
