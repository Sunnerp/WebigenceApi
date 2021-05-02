using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebigenceApi.Controllers
{
    public class PhotosController : ApiController
    {
        // GET: api/Photos ** Returns whole photos responses
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Photos/5 ** Returns specfic photo based on ID given
        public string Get(int id)
        {
            return "value";
        }

    }
}
