namespace NewsSystem.Data
{
  using Models;
  using System;
  using System.Activities.Statements;
  using System.Data.Entity;
  using System.Data.Entity.Infrastructure;

  public interface INewsSystemDbContext : IDisposable
  {
    int SaveChanges();
    IDbSet<User> Users { get; set; }

    IDbSet<Article> Articles { get; set; }
    IDbSet<Category> Cotegories { get; set; }
    IDbSet<Like> Likes { get; set; }

    // mandatory fod DbContext
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

  }
}
