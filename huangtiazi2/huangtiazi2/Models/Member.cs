using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huangtaizi.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<MemberReview> Reviews { get; set; }
    }
}