using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
   public class instrumentsDAO
   {
        public int Instruments_ID { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentDescription { get; set; }
        public decimal InstrumentPrice { get; set; }
   }
}
