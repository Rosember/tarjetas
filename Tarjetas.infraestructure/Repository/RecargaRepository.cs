using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Domain.Entity;
using Tarjetas.Domain.Interfaces;

namespace Tarjetas.infraestructure
{
    public class RecargaRepository : IRecarga
    {
        private BDTarjetasEntities bd = new BDTarjetasEntities();

        public List<Domain.Entity.Recarga> GetAll()
        {
            var all = bd.Recarga.ToList();
            return Get(all);
        }

        private List<Domain.Entity.Recarga> Get(List<Recarga> all)
        {
            var list = new List<Domain.Entity.Recarga>();
            foreach (var item in all)
            {
                list.Add(new Domain.Entity.Recarga(item.Id,item.Id_Cliente, item.Id_Usuario,item.Id_Tarjeta, item.Estado, item.fecha, item.monto));
            }
            return list;
        }

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
