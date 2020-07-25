using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace TokenAuthenticationWEBAPI.Controllers
{
    public class TestController : ApiController
    {
        //This resource is For all types of role
      [Authorize(Roles = "SuperAdmin, Admin, User")]
        [HttpGet]
        [Route("api/test/resource1")]
        public IHttpActionResult GetResource1()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var clientID=identity.Claims.FirstOrDefault(c => c.Type == "ClientKeyId").Value;
            var clientName = identity.Claims.FirstOrDefault(c => c.Type == "ClientName").Value;
            var clientSecret = identity.Claims.FirstOrDefault(c => c.Type == "ClientSecret").Value; 
            return Ok("Hello: " + identity.Name);
        }
    }
}
