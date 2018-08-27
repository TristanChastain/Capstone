using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class BandMembers
    {
        public int BandMembers_ID { get; set; }
        public string MemberName { get; set; }
        public string MemberBio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthLocation { get; set; }
    }
}
