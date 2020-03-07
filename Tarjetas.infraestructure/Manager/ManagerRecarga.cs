using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Domain.Interfaces;

namespace Tarjetas.infraestructure
{
    public class ManagerRecarga
    {
        private ITarjeta itarjeta;
        private IRecarga irecarga;
        private ICliente icliente;
        private IUser iusuario;

        public ManagerRecarga(ITarjeta tarjeta,IRecarga recarga, ICliente cliente ,IUser usuario)
        {
            itarjeta = tarjeta;
            irecarga = recarga;
            icliente = cliente;
            iusuario = usuario;
        }

        public List<Domain.Entity.Recarga> GetAllRecarga()
        {
            return irecarga.GetAll();
        }

        public void AumentarSaldo(string codigoTarjeta, string carnetCliente, string codigoUsuario, decimal money)
        {
            var resultTarjeta = itarjeta.FindByCodigo(codigoTarjeta);
            var resultUsuario = iusuario.FindByCodigo(codigoUsuario);
            var resultCliente = icliente.FindByCarnet(carnetCliente);

            irecarga.Recargar(resultTarjeta.Id, resultCliente.Id, resultUsuario.Id, money);
        }

        public void CancelReload(int id)
        {
            irecarga.CancelReload(id);
        }
    }
}
