using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queens_of_the_Stone_Age_Store.Models;
using DAL;
using DAL.Objects;

namespace Queens_of_the_Stone_Age_Store.Controllers
{
    public class UserController : Controller
    {
        static Mapper _mapper = new Mapper();
        static UserDataAccess _UserDataAccess = new UserDataAccess();
        [HttpGet]
        public ActionResult ViewUser()
        {
            UserViewModel _ViewModelUser = new UserViewModel();
            _ViewModelUser.UserList = _mapper._UserMap(_UserDataAccess.GetAllUsers());
            return View(_ViewModelUser);
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User Login)
        {
            if (ModelState.IsValid)
            {
                userDAO ValidateUser = new userDAO();
                ValidateUser = _UserDataAccess.Login(_mapper.SingleUser(Login));
                Session["User_ID"] = ValidateUser.User_ID;
                Session["Username"] = ValidateUser.Username;
                Session["Password"] = ValidateUser.Password;
                Session["Role_ID"] = ValidateUser.Role_ID;
            }
            return RedirectToAction("ManyView","Home");
        }
    }
}