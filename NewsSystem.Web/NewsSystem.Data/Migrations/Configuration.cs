namespace NewsSystem.Data.Migrations
{
  using Models;
  using NewsSystem.Migrations;
  using System.Data.Entity.Migrations;
  using System.Linq;

  public sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsSystemDbContext>
  {
    public Configuration()
    {
      // must allow automatic migration by default is false
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(NewsSystem.Data.NewsSystemDbContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data. E.g.
      //
      //    context.People.AddOrUpdate(
      //      p => p.FullName,
      //      new Person { FullName = "Andrew Peters" },
      //      new Person { FullName = "Brice Lambson" },
      //      new Person { FullName = "Rowan Miller" }
      //    );
      //

      if (context.Articles.Any())
      {
        return;
      }
      var user = new User()
      {
        UserName="Kon"
      };

      var seed = new SeedData(user);

      context.Users.Add(user);

      context.SaveChanges();

      seed.Categories.ForEach(x => context.Cotegories.Add(x));

      seed.Articles.ForEach(x => context.Articles.Add(x));

      context.SaveChanges();

    }
  }
}
