using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Application
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User CreateUser(User user);
    }
}
