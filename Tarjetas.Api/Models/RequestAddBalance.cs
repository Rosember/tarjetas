using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarjetas.Api.Models
{
    public class RequestAddBalance
    {
        public string CodigoTarjeta { get; set; }
        public string CarnetCliente { get; set; }
            public string CodigoUsuario { get; set; }
            public decimal Monto { get; set; }

    }
}