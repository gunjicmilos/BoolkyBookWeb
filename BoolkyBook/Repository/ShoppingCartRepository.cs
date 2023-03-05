using BoolkyBook.Data;
using BoolkyBook.Models;
using BoolkyBook.Repository.IRepository;

namespace BoolkyBook.Repository;

public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
{
    private ApplicationDbContext _db;
    public ShoppingCartRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }

    public int IncrementCount(ShoppingCart shoppingCart, int count)
    {
        return shoppingCart.Count += count;
    }

    public int DecrementCount(ShoppingCart shoppingCart, int count)
    {
        return shoppingCart.Count -= count;
    }
}