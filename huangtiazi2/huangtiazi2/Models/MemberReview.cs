using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huangtaizi.Models
{
    public class MemberReview
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public string ReviewerName { get; set; }
    }
}