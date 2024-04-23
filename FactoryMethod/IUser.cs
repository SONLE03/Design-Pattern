using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IUser
    {
        void createUser(String role);
        void updateUser(String role);
    }
}
