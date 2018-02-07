using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify.KnockKnock.Controllers
{
    public class TriangleTypeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(int a, int b, int c)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new Triangle().CheckTriangleType(a,b,c).ToString());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error");
            }
        }
    }
}
