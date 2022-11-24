using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthenticationDemo.Models;
namespace AuthenticationDemo.Controllers
{
    public class AccountsController : Controller
    {
        
        
        // GET: Accounts
       

        public ActionResult Login(User userModel)
        {
            using(Auth_Dotnet_80648Entities entities = new Auth_Dotnet_80648Entities()){
                bool IsvalidUser=entities.Users.Any(
                    user => user.UserName.ToLower() == userModel.UserName &&
                    userModel.UserPassword == userModel.UserPassword);

                if (IsvalidUser)
                {
                    FormsAuthentication.SetAuthCookie(userModel.UserName, false);
                    return (RedirectToAction("Index", "Employees"));
                }
                ModelState.AddModelError("", "Invalid credentials");
                return View();
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User user)
        {
            using(Auth_Dotnet_80648Entities entities = new Auth_Dotnet_80648Entities())
            {
                entities.Users.Add(user);
                entities.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Index()
        {
            return View("Index","Home");
        }
    }
}