namespace Armitage.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Armitage.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Armitage.Models.ApplicationDbContext context)
        {
            //Tags DbSet
            context.Tags.AddOrUpdate(x => x.TagId,
                new Tag() { TagId = 1, Name = "Food", Description = "COntent related to food.", CreatedOn = new DateTime(2016, 11, 1) },
                new Tag() { TagId = 2, Name="New York Times", Description="Content related to NYT.", CreatedOn = new DateTime(2016,11,1)}

            );

            context.Categories.AddOrUpdate(x => x.CategoryId,
                new Category() { CategoryId=1, Name="News", Description="For posts that relate mainly to news.", CreatedOn = new DateTime(2016,11,1)},
                new Category() { CategoryId=2, Name="Movies", Description="For posts that relate mainly to movies or films.", CreatedOn=new DateTime(2016,11,1)}

            );

            base.Seed(context);
        }
    }
}
