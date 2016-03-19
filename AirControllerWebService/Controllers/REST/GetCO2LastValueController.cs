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

                var valueInPercent = Convert.ToInt32(value / 70);

                return Request.CreateResponse(HttpStatusCode.OK, valueInPercent);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
