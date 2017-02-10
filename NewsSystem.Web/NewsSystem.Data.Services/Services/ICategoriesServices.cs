namespace NewsSystem.Data.Services.Services
{
  using NewsSystem.Data.Models;
  using System.Linq;
  public interface ICategoriesServices
  {
    IQueryable<Category> GetAll();
  }
}
