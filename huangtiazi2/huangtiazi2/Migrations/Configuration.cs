namespace Huangtaizi.Migrations
{
    using Huangtaizi.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HuangTaiZiDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Huangtaizi.Models.HuangTaiZiDb";
        }

        protected override void Seed(HuangTaiZiDb context)
        {
            //
            context.Members.AddOrUpdate(r => r.FirstName,
                new Member { FirstName = "Ben", LastName = "Zhang", State = "CA", City = "Fullerton", School = "CSUF" },
                new Member { FirstName = "Yi", LastName = "Liu", State = "CA", City = "Playa Del Ray", School = "USC" },
                new Member { FirstName = "Nick", LastName = "Lin", State = "CA", City = "Irvine", School = "UCI" },
                new Member
                {
                    FirstName = "Garrey",
                    LastName = "Xu",
                    State = "CA",
                    City = "Northridge",
                    School = "CLU",
                    Reviews =
                        new List<MemberReview> {
                            new MemberReview { Rating = 10.0, Comment = "Such a great player! ", ReviewerName = "Mesut Ozil"}
                        }
                });
        }
    }
}
