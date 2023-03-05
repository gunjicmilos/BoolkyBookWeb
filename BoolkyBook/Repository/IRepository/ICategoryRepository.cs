using BoolkyBook.Models;

namespace BoolkyBook.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category obj);
}