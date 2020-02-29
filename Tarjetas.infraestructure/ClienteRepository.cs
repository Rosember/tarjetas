using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.Entity;
using Tarjetas.Core.Interfaces;

namespace Tarjetas.infraestructure
{
    public class ClienteRepository : ICliente
    {
        private BDTarjetasEntities bd = new BDTarjetasEntities();

        public Core.Entity.Cliente FindByCarnet(string carnet)
        {
            var result = bd.Cliente.Where(b => b.Carnet.Trim().Equals(carnet.Trim())).FirstOrDefault();
            if (result != null)
            {
                return new Core.Entity.Cliente(result.Id, result.Nombre, result.Telefono, result.Carnet);
            }
            else
            {
                throw new ArgumentException("No se encotro el carnet del cliente en la base de datos");
            }
        }
    }
}
