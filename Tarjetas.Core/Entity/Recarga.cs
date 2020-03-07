using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.RecargaValueObject;
using Tarjetas.Domain.RecargaValueObject;

namespace Tarjetas.Domain.Entity
{
    public class Recarga
    {
        public int Id { get; set; }

        public int? IdCliente { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTarjeta { get; set; }
        public EstadoTarjetaValueObject Estado { get; set; }

        public FechaRecargaValueObject Fecha { get; set; }

        public MontoRecargaValueObject Monto { get; set; }

        public Recarga( int Id ,int? IdCliente, int? IdUsuario, int? IdTarjeta, int Estado,  DateTime? fecha,decimal? monto)
        {
            this.Id = Id;
            this.IdCliente = IdCliente;
            this.IdTarjeta = IdTarjeta;
            this.IdUsuario = IdUsuario;
            this.Estado = EstadoTarjetaValueObject.FromInt(Estado);
            Fecha = FechaRecargaValueObject.FromDate(fecha);
            Monto = MontoRecargaValueObject.FromDecimal(monto);
        }
    }
}
