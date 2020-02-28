using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tarjetas.Api.Models;
using Tarjetas.Core.Interfaces;
using Tarjetas.infraestructure;

namespace Tarjetas.Api.Controllers
{
    [RoutePrefix("api/Recarga")]
    public class RecargaController : ApiController
    {
        [HttpGet]
        [Route("aumentarSaldo/{codigoTarjeta}/{carnetCliente}/{codigoUsuario}/{monto:decimal}/")]
        public IHttpActionResult RealizarRecarga(string codigoTarjeta,string carnetCliente, string codigoUsuario, decimal monto)
        {
            try
            {
                IRecarga recarga = new RecargaRepository();
                recarga.Recargar(codigoTarjeta, carnetCliente, codigoUsuario, monto);
                return Ok(new JsonObjectResponse<Object>
                {
                    Id= 0,
                    Mensaje ="Excelente"
                });
            }
            catch (Exception e)
            {
                return Ok(new JsonObjectResponse<Object>
                {
                    Id = 1,
                    Mensaje = e.Message
                });
                
            }
        }
    }
}
