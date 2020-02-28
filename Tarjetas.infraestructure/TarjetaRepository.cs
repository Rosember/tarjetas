using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.Entity;
using Tarjetas.Core.Interfaces;

namespace Tarjetas.infraestructure
{
    public class TarjetaRepository : ITarjeta
    {
        private BDTarjetasEntities bd = new BDTarjetasEntities();

        public Core.Entity.Tarjeta FindByCodigo(string codigoTarjeta)
        {
            var result = bd.Tarjeta.Where(b => b.Codigo.Trim().Equals(codigoTarjeta.Trim())).FirstOrDefault();
            if (result!=null )
            {
                return new Core.Entity.Tarjeta(result.Id, result.Codigo);
            }
            else
            {
                throw new ArgumentException("No se encotro el codigo de la tarjeta en la base de datos");
            }
            
        }
    }
}
