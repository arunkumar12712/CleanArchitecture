using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        { 
            _userRepository = userRepository;
        }

        public User CreateUser(User user)
        {
            _userRepository.CreateUser(user);
            return user;
        }

        public List<User> GetAllUsers()
        {
            var users = _userRepository.GetAllusers();  
            return users;
        }
    }
}
