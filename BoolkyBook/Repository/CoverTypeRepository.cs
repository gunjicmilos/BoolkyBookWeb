using BoolkyBook.Data;
using BoolkyBook.Models;
using BoolkyBook.Repository.IRepository;

namespace BoolkyBook.Repository;

public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
{
    private ApplicationDbContext _db;
    public CoverTypeRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }

    public void Update(CoverType obj)
    {
        _db.CoverTypes.Update(obj);
    }
}