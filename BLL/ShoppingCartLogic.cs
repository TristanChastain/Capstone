using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Objects;

namespace BLL
{
    public class ShoppingCartLogic
    {
        public int Calc (List<shoppingcartBLO> _CartInfo)
        {//
            foreach (shoppingcartBLO _singleProduct in _CartInfo)
            {
                int PantSubTotal; int ShirtSubTotal; int SubTotal; int AllSubTotal = 0; int Shipping = 0;
                int AllSubTax = 0; int Tax = 0;
                PantSubTotal = _singleProduct.PantPrice * _singleProduct.PantQuanity;
                ShirtSubTotal = _singleProduct.ShirtPrice * _singleProduct.ShirtQuanity;
                {
                    SubTotal = PantSubTotal + ShirtSubTotal + Shipping;
                    AllSubTax = AllSubTotal * Tax;
                    Total += AllSubTotal + AllSubTax;
                }

            }
              return Total;
        }
    }
}
