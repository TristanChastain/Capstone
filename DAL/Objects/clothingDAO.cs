using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
    public class clothingDAO
    {
        public int Clothing_ID { get; set; }
        public string TypeOFClothing { get; set; }
        public string ClothingDescription { get; set; }
        public string Sizes { get; set; }
        public decimal ClothingPrice { get; set; }
        public string ClothingName { get; set; }
    }
}
