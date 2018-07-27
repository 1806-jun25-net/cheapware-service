using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/HardDrives")]
    [ApiController]
    public class HardDrivesController : ControllerBase
    {
        // GET: api/HardDrives
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetHardDrive()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HardDrives/5
        [HttpGet("{id}", Name = "GetHardDriveById")]
        public ActionResult<string> GetHardDriveById(int id)
        {
            return "value";
        }

        // POST: api/HardDrives
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/HardDrives/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
