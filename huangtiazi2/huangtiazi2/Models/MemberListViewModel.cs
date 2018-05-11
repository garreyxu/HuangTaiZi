using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huangtaizi.Models
{
    public class MemberListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string School { get; set; }
        public int CountOfReviews { get; set; }
    }
}