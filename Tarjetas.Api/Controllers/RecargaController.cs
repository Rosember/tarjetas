﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tarjetas.Api.Models;
using Tarjetas.Domain.Entity;
using Tarjetas.Domain.Interfaces;
using Tarjetas.infraestructure;

namespace Tarjetas.Api.Controllers
{
    [RoutePrefix("api/Recarga")]
    public class RecargaController : ApiController
    {
        private ManagerRecarga manager;

        public RecargaController()
        {
            manager = new ManagerRecarga(new TarjetaRepository(), 
                new RecargaRepository(), 
                new ClienteRepository(), 
                new UserRepository());
        }


        //[HttpGet]
        //[Route("realizarRecarga/{codigoTarjeta}/{carnetCliente}/{codigoUsuario}/{monto:decimal}/")]
        [HttpPost]
        [Route("realizarRecarga")]
        public IHttpActionResult RealizarRecarga([FromBody] RequestAddBalance request)
        {
            
            try
            {
                 
                manager.AumentarSaldo(request.CodigoTarjeta, request.CarnetCliente, request.CodigoUsuario, request.Monto);
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

        [HttpGet]
        [Route("ObtenerTodo")]
        public IHttpActionResult GetAllReload()
        {

            try
            {
                var response = manager.GetAllRecarga();
                return Ok(Format(response));
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


        [HttpGet]
        [Route("anularRecarga/{id:int}/")]
        public IHttpActionResult CancelReload( int id)
        {

            try
            {
                manager.CancelReload(id);
                return Ok(new JsonObjectResponse<Object>
                {
                    Id = 0,
                    Mensaje = "Correcto!!!"
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


        private List<ResponseGetAllRecarga> Format(List<Domain.Entity.Recarga> response)
        {
            var list = new List<ResponseGetAllRecarga>();
            foreach (var item in response)
            {
                list.Add(new ResponseGetAllRecarga()
                {
                    Id = item.Id,
                    Estado = item.Estado,
                    IdCliente = item.IdCliente,
                    Fecha = item.Fecha.value,
                    IdTarjeta = item.IdTarjeta,
                    IdUsuario = item.IdUsuario,
                    Monto = item.Monto.Value
                });
            }
            return list;
        }
    }
}
