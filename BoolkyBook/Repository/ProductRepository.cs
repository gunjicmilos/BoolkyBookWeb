using BoolkyBook.Data;
using BoolkyBook.Models;
using BoolkyBook.Repository.IRepository;

namespace BoolkyBook.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }

    public void Update(Product obj)
    {
        var objFromDb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
        if (obj != null)
        {
            objFromDb.Title = obj.Title;
            objFromDb.ISBN = obj.ISBN;
            objFromDb.ListPrice = obj.ListPrice;
            objFromDb.Price = obj.Price;
            objFromDb.Price50 = obj.Price50;
            objFromDb.Price100 = obj.Price100;
            objFromDb.Description = obj.Description;
            objFromDb.Author = obj.Author;
            objFromDb.CategoryId = obj.CategoryId;
            objFromDb.CoverTypeId = obj.CoverTypeId;
            if (obj.ImageUrl !=null)
            {
                objFromDb.ImageUrl = obj.ImageUrl;
            }
        }
    }
}