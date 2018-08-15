using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class Instruments
    {
        public int Instruments_ID { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentDescription { get; set; }
        public decimal InstrumentPrice { get; set; }
        public string BandMembers_ID { get; set; }
    }
}