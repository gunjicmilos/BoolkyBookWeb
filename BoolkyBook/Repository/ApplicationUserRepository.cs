using BoolkyBook.Data;
using BoolkyBook.Models;
using BoolkyBook.Repository.IRepository;

namespace BoolkyBook.Repository;

public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
{
    private ApplicationDbContext _db;
    public ApplicationUserRepository(ApplicationDbContext db): base(db)
    {
        _db = db;
    }
}