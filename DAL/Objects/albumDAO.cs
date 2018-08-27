using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
   public class albumDAO
        //comment for the push
   {    //comment
        public int Albums_ID { get; set; }
        public string AlbumName { get; set; }
        public string AlbumDescription { get; set; }
        public decimal AlbumPrice { get; set; }
        public DateTime YearReleased { get; set; }
        public int NumberOfSongs { get; set; }
   }
}
