using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FrameworkWebApi.Controllers
{
    public class StringsController : ApiController
    {
        // GET api/strings
        public IEnumerable<string> Get()
        {
            return Enumerable.Range(0, 100).Select(q => Guid.NewGuid().ToString());
        }
    }
}
