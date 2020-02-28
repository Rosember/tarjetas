using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Core.Interfaces
{
    public interface IRecarga
    {
        void Recargar(string codigoTarjeta, string carnetCliente, string codigoUsuario, decimal money);
    }
}
