using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Core.Interfaces
{
    public interface ITarjeta
    {
        Entity.Tarjeta FindByCodigo(string codigo);
    }
}
