using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class Album
    {
        public int Albums_ID { get; set; }
        public string AlbumName { get; set; }
        public string AlbumDescription { get; set; }
        public decimal AlbumPrice { get; set; }
        public DateTime YearReleased { get; set; }
        public int NumberOfSongs { get; set; }
    }
}