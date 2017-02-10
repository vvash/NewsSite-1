namespace NewsSystem.Web.App_Start
{
  using NewsSystem.Data;
  using NewsSystem.Data.Migrations;
  using System.Data.Entity;

  //initialize database
  // calling code in Global.asax
  public class DbConfig
  {
    public  static void Initialize()
    {
      Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsSystemDbContext, Configuration>());
      NewsSystemDbContext.Create().Database.Initialize(true);
    }
  }
}