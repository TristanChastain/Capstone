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
    public class ClothingController : Controller
    {
        static Mapper _mapper = new Mapper();
        static ClothingDataAccess _ClothingDataAccess = new ClothingDataAccess();
        [HttpGet]
        public ActionResult ClothingView()
        {
            ClothingViewModel _ViewModelClothing = new ClothingViewModel();
            _ViewModelClothing.ClothingList = _mapper.ClothingMap(_ClothingDataAccess.GetAllClothing());
            return View(_ViewModelClothing);
        }
        public ActionResult DeleteClothing (int Delete_Clothing)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                clothingDAO _DeleteClothing = new clothingDAO();
                _DeleteClothing.Clothing_ID = Delete_Clothing;
                _ClothingDataAccess.DeleteClothing(_DeleteClothing);
            }
            return RedirectToAction("ClothingView");
        }
        [HttpPost]
        public ActionResult CreateClothing(Clothing newClothing)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                clothingDAO ClothingToCreate = _mapper.SingleClothing(newClothing);
                _ClothingDataAccess.CreateClothing(ClothingToCreate);
            }
            return RedirectToAction("ClothingView");
        }
        [HttpPost]
        public ActionResult UpdateClothing(Clothing _ClothingInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                clothingDAO _recievedClothing = _mapper.SingleClothing(_ClothingInfo);
                _ClothingDataAccess.UpdateClothing(_recievedClothing);
                return RedirectToAction("ClothingView");
            }
            return RedirectToAction("ClothingView");
        }
        public ActionResult GetClothingID(int _GetID)
        {
            shoppingcartDAO cartToGet = new shoppingcartDAO();
            cartToGet.Clothing_ID = _GetID;
            cartToGet.User_ID = (int)Session["User_ID"];
            _ClothingDataAccess.GetClothingID(cartToGet);
            return RedirectToAction("ClothingView");
        }
        public ActionResult SendClothingID(int _SendID)
        {
            shoppingcartDAO cartToSend = new shoppingcartDAO();
            cartToSend.Clothing_ID = _SendID;
            cartToSend.User_ID = (int)Session["User_ID"];
            _ClothingDataAccess.SendClothingID(cartToSend);
            return RedirectToAction("ClothingView");
        }

    }
}

