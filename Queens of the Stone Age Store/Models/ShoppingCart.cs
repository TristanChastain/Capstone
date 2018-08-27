using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class ShoppingCart
    {
        public int ShoppingCart_ID { get; set; }
        public int Albums_ID { get; set; }
        public int Clothing_ID { get; set; }
        public int Instruments_ID { get; set; }
        public int User_ID { get; set; }
    }
}