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

        public UserService(MySQLDBContext context)
        {
            CreationDate = DateTime.Now;

            UserList = context.tb_User.ToList<User>();
        }

        public List<User> GetUsers()
        {
            return UserList;
        }
        public User GetUserById(string UserId)
        {
            return UserList.Where(us => us.Id.ToString() == UserId).FirstOrDefault();
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
