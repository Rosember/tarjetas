using System;
using Tarjetas.Domain.UserValueObject;

namespace Tarjetas.Domain.Entity
{
    public class User 
    {
        public int Id { get; set; }
        public NameUser Name { get; internal set; }
        public CodigoUsuarioValueObject Codigo { get; set; }
        public PasswordUserValueObject Password { get; set; }

        public User(int id, string name, string codigo, string password)
        {   
            Id = id;
            Name = NameUser.FromString(name);
            Codigo = CodigoUsuarioValueObject.FromString(codigo);
            Password = PasswordUserValueObject.FromString(password);
        }
    }
}
