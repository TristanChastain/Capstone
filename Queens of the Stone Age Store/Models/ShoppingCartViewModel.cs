using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart SingleShoppingCart { get; set; }
        public List<ShoppingCart> ShoppingCartList { get; set; }
        public ShoppingCartViewModel()
        {
            SingleShoppingCart = new ShoppingCart();
            ShoppingCartList = new List<ShoppingCart>();
        }
    }
}