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
        [HttpGet]
        public ActionResult UserView()
        {
            UserViewModel _ViewModelUser = new UserViewModel();
            _ViewModelUser.UserList = _mapper._UserMap(_UserDataAccess.GetAllUsers());
                return View(_ViewModelUser);
        }
        public ActionResult DeleteUser(int Delete_User)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                userDAO _DeleteUser = new userDAO();
                _DeleteUser.User_ID = Delete_User;
                _UserDataAccess.DeleteUser(_DeleteUser);
            }
            return RedirectToAction("UserView");
        }
        public ActionResult RegisterUser(User newUser)
        {
            //if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                userDAO UserToCreate = _mapper.SingleUser(newUser);
                _UserDataAccess.Createuser(UserToCreate);
            }
            return RedirectToAction("UserView");
        }
        public ActionResult UpdateUser(User _UserInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                userDAO _recievedUser = _mapper.SingleUser(_UserInfo);
                _UserDataAccess.UpdateUser(_recievedUser);
            }
            return RedirectToAction("UserView");
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("UserLogin");
        }
    }
}