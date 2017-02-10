namespace NewsSystem.Data.Services.Services
{
  using NewsSystem.Data.Models;
  using System.Linq;
  public interface IArticlesServices
  {
    IQueryable<Article> GetTop(int count);
    IQueryable<Article> GetAll();

  }
}
