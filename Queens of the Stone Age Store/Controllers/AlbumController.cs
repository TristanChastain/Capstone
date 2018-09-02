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
    public class AlbumController : Controller
    {
        static Mapper _mapper = new Mapper();
        static AlbumDataAccess _AlbumDataAccess = new AlbumDataAccess();
        [HttpGet]
        public ActionResult AlbumView()
        {
            AlbumViewModel _ViewModelAlbum = new AlbumViewModel();
            _ViewModelAlbum.AlbumList = _mapper.AlbumMap(_AlbumDataAccess.GetAllAlbums());
            return View(_ViewModelAlbum);
        }
        public ActionResult DeleteAlbum(int Delete_Album)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                albumDAO _DeleteAlbum = new albumDAO();
                _DeleteAlbum.Albums_ID = Delete_Album;
                _AlbumDataAccess.DeleteAlbum(_DeleteAlbum);
            }
            return RedirectToAction("AlbumView");
        }
        [HttpPost]
        public ActionResult CreateAlbum(Album newAlbum)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                albumDAO AlbumToCreate = _mapper.SingleAlbum(newAlbum);
                _AlbumDataAccess.CreateAlbum(AlbumToCreate);
            }
            return RedirectToAction("AlbumView");
        }
        [HttpPost]
        public ActionResult UpdateAlbum(Album _AlbumInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                albumDAO _recievedAlbum = _mapper.SingleAlbum(_AlbumInfo);
                _AlbumDataAccess.UpdateAlbum(_recievedAlbum);
            }
            return RedirectToAction("AlbumView");
        }
        public ActionResult GetAlbumID(int _GetID)
        {
            shoppingcartDAO cartToGet = new shoppingcartDAO();
            cartToGet.Albums_ID = _GetID;
            cartToGet.User_ID = (int)Session["User_ID"];
            _AlbumDataAccess.GetAlbumID(cartToGet);
            return RedirectToAction("AlbumView");
        }
        public ActionResult SendAlbumsID(int _SendID)
        {
            shoppingcartDAO cartToSend = new shoppingcartDAO();
            cartToSend.Albums_ID = _SendID;
            cartToSend.User_ID = (int)Session["User_ID"];
            _AlbumDataAccess.SendAlbumsID(cartToSend);
            return RedirectToAction("AlbumView");
        }
        
    }
}