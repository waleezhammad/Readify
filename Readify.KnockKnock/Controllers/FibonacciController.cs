using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Readify.KnockKnock.Controllers
{

    public class FibonacciController : ApiController
    {
        
        [HttpGet]
        public HttpResponseMessage Get(int n)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new Fibonacci().GetFibonacci(n));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,"no content");
            }

        }
    }
}
