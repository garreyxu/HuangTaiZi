using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Huangtaizi.Models
{
    public class HuangTaiZiDb : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberReview> MemberReviews { get; set; }
    }
}