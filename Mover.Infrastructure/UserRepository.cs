using Mover.Application;
using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly MoverDbContext _moverDbContext;
        public UserRepository(MoverDbContext moverDbContext)
        {
            _moverDbContext = moverDbContext;
        }
        public User CreateUser(User user)
        {
            _moverDbContext.Users.Add(user);
            _moverDbContext.SaveChanges();
            return user;
        }

        public List<User> GetAllusers()
        {
            return _moverDbContext.Users.ToList();
        }
    }
}
