namespace NewsSystem.Data.Services.Services
{
  using System;
  using System.Linq;
  using NewsSystem.Data.Models;
  using NewsSystem.Data.Repositories;

  public class ArticlesServices : IArticlesServices
  {
    private IRepository<Article> articles;
    public ArticlesServices(IRepository<Article> articles)
    {
      this.articles = articles;
    }
    public IQueryable<Article> GetAll()
    {
      return this.articles.All();
    }

    public IQueryable<Article> GetTop(int count)
    {
      return this.articles.All().OrderByDescending(x => x.Likes.Count()).Take(count);
    }
  }
}
