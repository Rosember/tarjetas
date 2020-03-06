using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Domain.Entity;
using Tarjetas.Domain.Interfaces;

namespace Tarjetas.infraestructure
{
    public class UserRepository : IUser
    {

        private BDTarjetasEntities bd = new BDTarjetasEntities();

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public User FindByCodigo(string codigo)
        {
            var result = bd.Usuario.Where(b => b.Codigo .Trim().Equals(codigo.Trim())).FirstOrDefault();
            if (result != null)
            {
                return new Domain.Entity.User(result.Id, result.Nombre, result.Codigo,result.Password);
            }
            else
            {
                throw new ArgumentException("No se encotro el codigo del usuario en la base de datos");
            }
        }

        public User FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUSers()
        {
            var result = bd.Usuario.ToList();
            if (result!=null && result.Count>0)
            {
                var users = new List<User>();
                foreach (var item in result)
                {
                    users.Add(Conertir(item));
                }
                return users;
            }
            return new List<User>();
        }

        private User Conertir(Usuario item)
        {
            return new User(item.Id, item.Nombre, item.Codigo, item.Password);
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
