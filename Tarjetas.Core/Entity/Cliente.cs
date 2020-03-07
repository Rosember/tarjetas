using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Domain.ClienteValueObject;

namespace Tarjetas.Domain.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public NombreClienteValueObject Name { get; internal set; }
        public TelefonoClienteValueObject telefono { get; set; }
        public CarnetClienteValueObject carnet_identidad { get; set; }

        public Cliente(int id, string name, string telefono, string carnet_identidad)
        {
            Id = id;
            Name = NombreClienteValueObject.FromString(name);
            this.telefono = TelefonoClienteValueObject.FromString(telefono);
            this.carnet_identidad = CarnetClienteValueObject.FromString(carnet_identidad);
        }
    }
}
