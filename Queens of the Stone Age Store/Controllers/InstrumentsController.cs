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
    public class InstrumentsController : Controller
    {
        static Mapper _mapper = new Mapper();
        static InstrumentDataAccess _InstrumentDataAccess = new InstrumentDataAccess();
        [HttpGet]
        public ActionResult InstrumentsView()
        {
            InstrumentsViewModel _ViewModelInstruments = new InstrumentsViewModel();
            _ViewModelInstruments.InstrumentList = _mapper.InstrumentsMap(_InstrumentDataAccess.GetAllInstruments());
                return View(_ViewModelInstruments);
        }
        public ActionResult DeleteInstrument(int Delete_Instrument)
        {
            if ((int)Session["Role_ID"] == 3)
            {
                instrumentsDAO _DeleteInstrument = new instrumentsDAO();
                _DeleteInstrument.Instruments_ID = Delete_Instrument;
                _InstrumentDataAccess.DeleteInstruments(_DeleteInstrument);
            }
            return RedirectToAction("InstrumentsView");
        }
        [HttpPost]
        public ActionResult CreateInstrument(Instruments newInstruments)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                instrumentsDAO InstrumentToCreate = _mapper.SingleInstrument(newInstruments);
                _InstrumentDataAccess.CreateInstruments(InstrumentToCreate);
            }
            return RedirectToAction("InstrumentsView");
        }
        [HttpPost]
        public ActionResult UpdateInstrument(Instruments _InstrumentsInfo)
        {
            if ((int)Session["Role_ID"] == 3 || (int)Session["Role_ID"] == 2)
            {
                instrumentsDAO _recievedInstrument = _mapper.SingleInstrument(_InstrumentsInfo);
                _InstrumentDataAccess.UpdateInstrument(_recievedInstrument);
                return RedirectToAction("InstrumentsView");
            }
            return RedirectToAction("InstrumentsView");
        }
    }
}