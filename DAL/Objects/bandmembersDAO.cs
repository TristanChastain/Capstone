using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Objects
{
   public class bandmembersDAO
    {
        public int BandMembers_ID { get; set; }
        public string MemberName { get; set; }
        public string MemberBio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthLocation { get; set; }
    }
}
