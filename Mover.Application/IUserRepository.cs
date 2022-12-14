using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Application
{
    public interface IUserRepository
    {
        List<User> GetAllusers();
        User CreateUser(User user);
    }
}
