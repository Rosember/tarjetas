﻿using System;
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

            new Domain.Entity.Recarga(1, idCliente, idUsuario, idTarjeta, 1, DateTime.Now, money);
            using (var bdconextTransaction =bd.Database.BeginTransaction())
            {
                try
                {
                    bd.Recarga.Add(new Recarga()
                    {
                        fecha = DateTime.Now,
                        monto = money,
                        Id_Cliente = idCliente,
                        Id_Tarjeta = idTarjeta,
                        Id_Usuario = idUsuario,
                        Estado = 1
                    });

                    var result = bd.Tarjeta_Cliente.SingleOrDefault(b => b.Id_Tarjeta == idTarjeta && b.Id_Cliente == idCliente);
                    if (result != null)
                    {
                        result.Saldo = result.Saldo + money;
                    }
                    bd.SaveChanges();
                    bdconextTransaction.Commit();
                }
                catch (Exception e)
                {
                    
                    bdconextTransaction.Rollback();
                    throw new ArgumentException(e.Message);
                }
            }
            
        }

        public void CancelReload(int id)
        {
            using (var bdconextTransaction = bd.Database.BeginTransaction())
            {
                try
                {
                    var recarga = bd.Recarga.SingleOrDefault(b => b.Id == id);
                    if (recarga==null)
                    {
                        throw new ArgumentException("there is no ID= "+id);
                    }
                    recarga.Estado = 2;

                    var result = bd.Tarjeta_Cliente.SingleOrDefault(b => b.Id_Tarjeta == recarga.Id_Tarjeta);
                    if (result != null)
                    {
                        result.Saldo = result.Saldo - recarga.monto;
                    }
                    bd.SaveChanges();
                    bdconextTransaction.Commit();
                }
                catch (Exception e)
                {

                    bdconextTransaction.Rollback();
                    throw new ArgumentException(e.Message);
                }
            }
        }
    }
}
