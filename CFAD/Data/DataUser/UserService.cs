using CFAD.Models;
using CFAD.Models.Companys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Data
{
    public class UserService: IUserService
    {
        public DateTime CreationDate { get; set; }
        public List<User> UserList { get; set; }

        public UserService(ApplicationDbContext context)
        {
            CreationDate = DateTime.Now;

            UserList = context.CFAD_User.ToList<User>();
        }

        public List<User> GetUsers()
        {
            return UserList;
        }
        public User GetUserById(Guid UserId)
        {
            return UserList.Where(us => us.Id == UserId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }
    }
}
