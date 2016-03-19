using AirControllerWebService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirControllerWebService.Controllers.REST
{
    public class GetCO2LastValueController : ApiController
    {
        public HttpResponseMessage Get()
        {
            try
            {
                var value = ManageDB.GetCO2LastValue();

                return Request.CreateResponse(HttpStatusCode.OK, value);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
