using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; internal set; }
        public string telefono { get; set; }
        public string carnet_identidad { get; set; }

        public Cliente(int id, string name, string telefono, string carnet_identidad)
        {
            Id = id;
            Name = name;
            this.telefono = telefono;
            this.carnet_identidad = carnet_identidad;
        }
    }
}
