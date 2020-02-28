using System;
using Tarjetas.Core.UserValueObject;

namespace Tarjetas.Core.Entity
{
    public class User 
    {
        public int Id { get; set; }
        public NameUser Name { get; internal set; }
        public string Codigo { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string codigo, string password)
        {   
            Id = id;
            Name = NameUser.FromString(name);
            Codigo = codigo;
            Password = password;
        }
    }
}
