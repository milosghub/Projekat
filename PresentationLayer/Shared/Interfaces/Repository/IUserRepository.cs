﻿using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
   public interface IUserRepository 
    {

         List<User> GetUsers();
         int InsertUser(User user);
    }
}
