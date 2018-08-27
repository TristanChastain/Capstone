using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
   public class shoppingcartDAO
    {
        public int ShoppingCart_ID { get; set; }
        public int Albums_ID { get; set; }
        public int Clothing_ID { get; set; }
        public int Instruments_ID { get; set; }
        public int User_ID { get; set; }
        public decimal AlbumPrice { get; set; }
        public decimal ClothingPrice { get; set; }
        public decimal InstrumentsPrice { get; set; }
    }
}
