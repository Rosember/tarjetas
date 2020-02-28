using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tarjetas.Core.Interfaces;
using Tarjetas.infraestructure;

namespace Tarjetas.Api.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {

        private IUser _user;

        [HttpGet]
        [Route("getUser")]
        public IHttpActionResult getUser()
        {
            _user = new UserRepository();
            var users = _user.GetUSers();
            return Ok(users);
        }
    }
}