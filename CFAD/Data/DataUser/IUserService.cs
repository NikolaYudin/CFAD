using CFAD.Models;
using CFAD.Models.Companys;
using System;
using System.Collections.Generic;

namespace CFAD.Data
{
    public interface IUserService
    {
        public List<User> GetUsers(); 
        public string GetVersion();
        public DateTime GetCreatedDate();
        public User GetUserById(Guid UserId);
    }
}