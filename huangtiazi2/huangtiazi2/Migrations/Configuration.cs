namespace huangtiazi2.Migrations
{
    using Huangtaizi.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Huangtaizi.Models.HuangTaiZiDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Huangtaizi.Models.HuangTaiZiDb";
        }

        protected override void Seed(Huangtaizi.Models.HuangTaiZiDb context)
        {
            context.Members.AddOrUpdate(m => m.FirstName + m.LastName,
                new Member { FirstName = "Ben", LastName = "Zhang" },
                new Member { FirstName = "Yi", LastName = "Liu" },
                new Member { FirstName = "Nick", LastName = "Lin" },
                new Member
                {
                    FirstName = "Garrey",
                    LastName = "Xu",
                    Reviews =
                        new List<MemberReview> {
                            new MemberReview { Rating = 10.0, Comment = "Such a great player. " }
                        }
                });
        }
    }
}
