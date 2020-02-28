using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.Entity;
using Tarjetas.Core.Interfaces;

namespace Tarjetas.infraestructure
{
    public class UserRepository : IUser
    {



        public void Add(User user)
        {
            
        }

        public void Edit(User user)
        {
            
        }

        public User FindById(int Id)
        {
            return new User(1, "Rosember Carrasco", "6543321", "Hello123");
        }

        public List<User> GetUSers()
        {
            return new List<User>() {
                new User(1, null, "6543321", "Hello123"),
                new User(2, "Carlos Cruz", "32516", "95311")
            };
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
