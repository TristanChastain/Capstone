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
    public class BandMemberController : Controller
    {
        static Mapper _mapper = new Mapper();
        static BandMemberDataAccess _BandMemberDataAccess = new BandMemberDataAccess();
        [HttpGet]
        public ActionResult BandMemberView()
        {
            BandMembersViewModel _ViewModelBandMember = new BandMembersViewModel();
            _ViewModelBandMember.MembersList = _mapper.MemeberMap(_BandMemberDataAccess.GetAllMembers());
            return View(_ViewModelBandMember);
        }
        public ActionResult DeleteMember(int Delete_Member)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                bandmembersDAO _DeleteMember = new bandmembersDAO();
                _DeleteMember.BandMembers_ID = Delete_Member;
                _BandMemberDataAccess.DeleteMember(_DeleteMember);
            }
            return RedirectToAction("BandMemberView");
        }
        [HttpPost]
        public ActionResult CreateMember(BandMembers newMember)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                bandmembersDAO MemberToCreate = _mapper.SingleMember(newMember);
                _BandMemberDataAccess.CreateMember(MemberToCreate);
            }
            return RedirectToAction("BandMemberView");
        }
        [HttpPost]
        public ActionResult UpdateMember(BandMembers _MemberInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                bandmembersDAO _recievedMember = _mapper.SingleMember(_MemberInfo);
                _BandMemberDataAccess.UpdateMember(_recievedMember);
            }
            return RedirectToAction("BandMemberView");
        }
    }
}