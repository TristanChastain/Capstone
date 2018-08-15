using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class ClothingViewModel
    {
        public Clothing SingleClothing { get; set; }
        public List<Clothing> ClothingList { get; set; }
        public ClothingViewModel()
        {
            SingleClothing = new Clothing();
            ClothingList = new List<Clothing>();
        }
    }
}