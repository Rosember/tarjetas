using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarjetas.Api.Models
{
    public class JsonObjectResponse<T>
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }
    }
}