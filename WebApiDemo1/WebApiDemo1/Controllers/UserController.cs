using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo1.Models;

namespace WebApiDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        static List<UserModel> userList;

        public UserController()
        {
            userList = new List<UserModel>()
            {
                new UserModel(){id=1,name="Harry Potter",email="harry@gmail.com"},
                new UserModel(){id=2,name="Ronald Weasley",email="ronald@gmail.com"},
                new UserModel(){id=3,name="Hermione Granger",email="hermione@gmail.com"}
            };
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return userList;
        }

        [HttpGet("{id}")]
        public UserModel GetUserById(int id)
        {
            UserModel user = userList.FirstOrDefault(u => u.id == id);
            return user;
        }

       [HttpPost]
       public IEnumerable<UserModel> postUser(UserModel userModel)
        {
            userList.Add(userModel);
            return userList;
        }
        [HttpPut]
        public IEnumerable<UserModel> putUser(UserModel userModel)
        {
            int index = userList.FindIndex(u => u.id == userModel.id);
            userList[index]=userModel;
            return userList;
        }
        [HttpDelete]
        public void DelUser(UserModel userModel)
        {
            UserModel user = userList.FirstOrDefault(u => u.id == userModel.id);
            userList.Remove(user);
        }
    }
}
