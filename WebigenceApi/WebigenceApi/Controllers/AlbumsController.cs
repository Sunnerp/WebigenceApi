using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebigenceApi.Controllers
{
    public class AlbumsController : ApiController
    {
        // GET: api/Albums ** Returns whole album responses
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Albums/5 ** Returns specfic album based on ID given
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Albums
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Albums/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Albums/5
        public void Delete(int id)
        {
        }
    }
}
