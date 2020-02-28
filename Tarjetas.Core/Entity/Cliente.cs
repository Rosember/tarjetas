using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Core.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; internal set; }
        public string telefono { get; set; }
        public string carnet_identidad { get; set; }
    }
}
