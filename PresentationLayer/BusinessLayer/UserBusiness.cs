using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository userRepository;

        public UserBusiness(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }
        public List<User> Get()
        {
            return this.userRepository.GetUsers();
        }
        public bool Insert(User s)
        {
            if (this.userRepository.InsertUser(s) > 0)
                return true;
            return false;
        }
    }
}
