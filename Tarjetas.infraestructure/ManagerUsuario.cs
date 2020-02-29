using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarjetas.Core.Entity;
using Tarjetas.Core.Interfaces;

namespace Tarjetas.infraestructure
{
    public class ManagerUsuario
    {
        private IUser iuser;

        public ManagerUsuario(IUser iuser)
        {
            this.iuser = iuser;
        }

        public List<User> getAllUser()
        {
            return iuser.GetUSers();
        }
    }
}
