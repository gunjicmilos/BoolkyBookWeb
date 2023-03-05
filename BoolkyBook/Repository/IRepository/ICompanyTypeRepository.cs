using BoolkyBook.Models;

namespace BoolkyBook.Repository.IRepository;

public interface ICompanyRepository : IRepository<Company>
{
    void Update(Company obj);
}