using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFAD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CUserController : ControllerBase
    {
        // GET: api/CUser
        [HttpGet("[action]")]
        public UserModel GetUser()
        {
            // Instantiate a UserModel
            var userModel = new UserModel
            {
                UserName = "[]",
                IsAuthenticated = false
            };
            // Detect if the user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                // Set the username of the authenticated user
                userModel.UserName =
                    User.Identity.Name;
                userModel.IsAuthenticated =
                    User.Identity.IsAuthenticated;
            };
            return userModel;
        }
    }
}

// Class to hold the UserModel
public class UserModel
{
    public string UserName { get; set; }
    public bool IsAuthenticated { get; set; }
}