namespace huangtiazi2.Migrations
{
    using System;
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
            
        }
    }
}
