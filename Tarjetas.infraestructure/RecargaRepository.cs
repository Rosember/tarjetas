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
        private BDTarjetasEntities bd = new BDTarjetasEntities();

        public void Recargar(int idTarjeta, int idCliente, int idUsuario, decimal money)
        {

            bd.Recarga.Add(new Recarga()
            {
                fecha = DateTime.Now,
                monto = money,
                Id_Cliente= idCliente,
                Id_Tarjeta = idTarjeta,
                Id_Usuario = idUsuario
            });
            bd.SaveChanges();
        }


    }
}
