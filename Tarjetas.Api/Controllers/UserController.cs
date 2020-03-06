using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tarjetas.Domain.Interfaces;
using Tarjetas.infraestructure;

namespace Tarjetas.Api.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {

        

        [HttpGet]
        [Route("getUser")]
        public IHttpActionResult getUser()
        {
            ManagerUsuario managerUsuario = new ManagerUsuario(new UserRepository());
            var users = managerUsuario.getAllUser();
            return Ok(users);
        }
    }
}