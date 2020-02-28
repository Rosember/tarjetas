using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Core.Entity
{
    public class Recarga
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

    }
}
