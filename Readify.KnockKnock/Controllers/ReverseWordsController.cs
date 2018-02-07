using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify.KnockKnock.Controllers
{
    public class ReverseWordsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(string sentence="")
        {
            try
            {
                if (string.IsNullOrEmpty(sentence))
                    return Request.CreateResponse(HttpStatusCode.OK, string.Empty);

                return Request.CreateResponse(HttpStatusCode.OK, sentence.ReverseEachWord());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "");
            }
        }
    }
}
