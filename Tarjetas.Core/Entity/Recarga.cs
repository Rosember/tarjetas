using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.RecargaValueObject;

namespace Tarjetas.Core.Entity
{
    public class Recarga
    {
        public int Id { get; set; }
        public FechaRecargaValueObject Fecha { get; set; }

        public MontoRecargaValueObject Monto { get; set; }

        public Recarga(DateTime fecha,decimal monto)
        {
            Fecha = FechaRecargaValueObject.FromDate(fecha);
            Monto = MontoRecargaValueObject.FromDecimal(monto);
        }
    }
}
