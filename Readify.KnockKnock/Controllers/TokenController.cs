using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify.KnockKnock.Controllers
{
    public class TokenController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "512de197-0976-4c8e-806e-89998de879f3");
        }
    }
}
