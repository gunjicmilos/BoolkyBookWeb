using BoolkyBook.Models;

namespace BoolkyBook.Repository.IRepository;

public interface IOrderDetailRepository : IRepository<OrderDetail>
{
    void Update(OrderDetail obj);
}