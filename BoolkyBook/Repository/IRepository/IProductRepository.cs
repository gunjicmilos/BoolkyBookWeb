using BoolkyBook.Models;

namespace BoolkyBook.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}