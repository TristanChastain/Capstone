using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
   public class userDAO
   {
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role_ID { get; set; }
        public int ShoppingCart_ID { get; set; }
        public int Albums_ID { get; set; }
        public int Clothing_ID { get; set; }
        public int Instruments_ID { get; set; }
       
    }
}
