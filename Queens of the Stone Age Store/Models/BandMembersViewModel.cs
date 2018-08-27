using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class BandMembersViewModel
    {
        public BandMembers SingleMember { get; set; }
        public List<BandMembers> MembersList { get; set; }
        public BandMembersViewModel()
        {
            SingleMember = new BandMembers();
            MembersList = new List<BandMembers>();
        }
    }
}