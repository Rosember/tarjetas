﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjetas.Domain.Interfaces
{
    public interface IRecarga
    {
        void Recargar(int idTarjeta, int idCliente, int idUsuario, decimal money);
    }
}
