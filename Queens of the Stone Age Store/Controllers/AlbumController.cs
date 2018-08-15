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
    }
}