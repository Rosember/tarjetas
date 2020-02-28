using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.RecargaValueObject;

namespace Tarjetas.Core.Entity
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public CodigoTarjeta Codigo { get; set; }

        public Tarjeta(int id, string codigo)
        {
            Id = id;
            Codigo = CodigoTarjeta.FromString(codigo);
        }
    }
}
