using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queens_of_the_Stone_Age_Store.Models;
using DAL;
using DAL.Objects;
using BLL;
using BLL.Objects;

namespace Queens_of_the_Stone_Age_Store.Controllers
{
    public class ShoppingCartController : Controller
    {
        static Mapper _mapper = new Mapper();
        static ShoppingCartDataAccess _shoppingcartDataAccess = new ShoppingCartDataAccess();
        //static ShoppingCartLogic _ShoppingCartLogic = new ShoppingCartLogic();

        [HttpGet]
        public ActionResult ShoppingCartView(int User_ID)
        {
            ShoppingCartViewModel _ShoppingCartViewModel = new ShoppingCartViewModel();
            _ShoppingCartViewModel.ShoppingCartList = _mapper.ShoppingCartMap
                (_shoppingcartDataAccess.GetAllShoppingCarts(User_ID));
            return View(_ShoppingCartViewModel);
        }
        public ActionResult DeleteShoppingCart(int Delete_ShoppingCart)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                shoppingcartDAO _DeleteShoppingCart = new shoppingcartDAO();
                _DeleteShoppingCart.ShoppingCart_ID = Delete_ShoppingCart;
                _shoppingcartDataAccess.DeleteShoppingCart(_DeleteShoppingCart);
            }
            return RedirectToAction("ShoppingCartView");
        }
        [HttpPost]
        public ActionResult CreateShoppingCart(ShoppingCart newShoppingCart)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                shoppingcartDAO CartToCreate = _mapper.SingleShoppingCart(newShoppingCart);
                _shoppingcartDataAccess.CreateShoppingCart(CartToCreate);
            }
            return RedirectToAction("ShoppingCartView");
        }
        public ActionResult UpdateShoppingCart(ShoppingCart _CartInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                shoppingcartDAO _recievedCart = _mapper.SingleShoppingCart(_CartInfo);
                _shoppingcartDataAccess.UpdateShoppingCart(_recievedCart);
            }
            return RedirectToAction("ShoppingCartView");
        }
       /*static ShoppingCartLogic _ShoppingCartLogic = new ShoppingCartLogic();
        ActionResult Checkout(shoppingcartBLO _totalPrice)
        {
           int TotalPrice = _ShoppingCartLogic.Calc(ShoppingCartLogicMap);
        }*/
    }
}