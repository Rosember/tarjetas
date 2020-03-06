using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Domain.Entity;

namespace Tarjetas.Domain.Interfaces
{
    public interface IUser
    {
        void Add(User p);
        void Edit(User p);
        void Remove(int Id);
        List<User> GetUSers();
        User FindById(int Id);
        User FindByCodigo(string codigo);
    }
}
