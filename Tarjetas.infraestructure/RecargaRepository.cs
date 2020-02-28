using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.Entity;
using Tarjetas.Core.Interfaces;

namespace Tarjetas.infraestructure
{
    public class RecargaRepository : IRecarga
    {
        public void Recargar(string codigoTarjeta, string carnetCliente, string codigoUsuario, decimal money)
        {
            Tarjeta t = new Tarjeta(1, codigoTarjeta);
            DateTime fecha = DateTime.Now;
            Recarga recarga = new Recarga(fecha, money);
                            
        }
    }
}
