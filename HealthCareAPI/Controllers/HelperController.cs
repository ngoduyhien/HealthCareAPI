using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthCareAPI.Controllers
{
    public class HelperController : ApiController
    {
        // GET api/values
        [Route("api/helper/getall/{collection_name}")]
        public IEnumerable<string> Get(string collection_name)
        {
            var list = new List<FoodDto>();
            return new string[] { "Çhuc Mung Nam moi 2020", "Nguyen Vu Long" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
