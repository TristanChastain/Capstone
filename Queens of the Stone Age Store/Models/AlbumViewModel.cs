using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class AlbumViewModel
    {
        public Album SingleAlbum { get; set; }
        public List<Album> AlbumList { get; set; }
        public AlbumViewModel()
        {
            SingleAlbum = new Album();
            AlbumList = new List<Album>();
        }
    }
}