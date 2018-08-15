using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class Clothing
    {
        public int Clothing_ID { get; set; }
        public string TypeOFClothing { get; set; }
        public string ClothingDescription { get; set; }
        public string Sizes { get; set; }
        public decimal ClothingPrice { get; set; }
        public string ClothingName { get; set; }
    }
}