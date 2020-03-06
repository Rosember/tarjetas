using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.Interfaces
{
    public interface ICliente
    {
        Entity.Cliente FindByCarnet(string carnet);
    }
}
