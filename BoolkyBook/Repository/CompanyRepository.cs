using BoolkyBook.Data;
using BoolkyBook.Models;
using BoolkyBook.Repository.IRepository;

namespace BoolkyBook.Repository;

public class CompanyRepository : Repository<Company>, ICompanyRepository
{
    private ApplicationDbContext _db;
    public CompanyRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }

    public void Update(Company obj)
    {
        _db.Update(obj);
    }
}