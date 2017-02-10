namespace NewsSystem.Data.Services.Services
{
  using System.Linq;
  using NewsSystem.Data.Models;
  using NewsSystem.Data.Repositories;

  public class CategoriesServices : ICategoriesServices
  {
    private IRepository<Category> categories;
    public CategoriesServices(IRepository<Category> articles)
    {
      this.categories = articles;
    }
    public IQueryable<Category> GetAll()
    {
      return this.categories.All();
    }
  }
}
