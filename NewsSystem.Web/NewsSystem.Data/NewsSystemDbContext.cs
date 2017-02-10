namespace NewsSystem.Data
{
  using System;
  using System.Data.Entity;
  using Microsoft.AspNet.Identity.EntityFramework;
  using NewsSystem.Data.Models;

  public class NewsSystemDbContext : IdentityDbContext<User>, INewsSystemDbContext
  {
    public NewsSystemDbContext()
        : base("DefaultConnection", throwIfV1Schema: false)
    {
    }

    public IDbSet<Article> Articles { get; set; }

    public IDbSet<Category> Cotegories { get; set; }

    public IDbSet<Like> Likes { get; set; }

    public static NewsSystemDbContext Create()
    {
      return new NewsSystemDbContext();
    }
  }
}
