using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class InstrumentsViewModel
    {
        public Instruments SingleInstrument { get; set; }
        public List<Instruments> InstrumentList { get; set; }
        public InstrumentsViewModel()
        {
            SingleInstrument = new Instruments();
            InstrumentList = new List<Instruments>();
        }

    }
}