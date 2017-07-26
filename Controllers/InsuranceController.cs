using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AnalysisServices.Core;

 

namespace BlkDataViz.Controllers
{

    [Route("api/[controller]")]
    public class InsuranceController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "homeowners","renters" };
        }

        // GET api/insurance/homeowners
        [HttpGet("homeowners")]
        public IEnumerable<string> GetInsuranceHomeowners()
        {
            return new string[] { "carriers" };
        }

         // GET /api/insurance/homeowners/1/carriers
        [Route("homeowners/{buildingId:int}/carriers")]
        public IEnumerable<Carriers> GetInsuranceHomeownersCarriersByBuilding(int buildingId) { 

            //AdomdDataAdapter da = new AdomdDataAdapter();

            Carriers[] c  = new Carriers[2];
            c[0]=new Carriers("State Farm",38);
            c[1]=new Carriers("Lemonade",57);
            return c;
        }

        // GET api/insurance/5
        [HttpGet("homeowners/{id}")]
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
