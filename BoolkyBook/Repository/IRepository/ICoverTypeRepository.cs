using BoolkyBook.Models;

namespace BoolkyBook.Repository.IRepository;

public interface ICoverTypeRepository : IRepository<CoverType>
{
    void Update(CoverType obj);
}