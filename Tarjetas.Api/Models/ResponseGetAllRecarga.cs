using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarjetas.Api.Models
{
    public class ResponseGetAllRecarga
    {
        public int Id { get; set; }

        public int? IdCliente { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTarjeta { get; set; }
        public int? Estado { get; set; }

        public DateTime? Fecha { get; set; }

        public decimal? Monto { get; set; }
    }
}