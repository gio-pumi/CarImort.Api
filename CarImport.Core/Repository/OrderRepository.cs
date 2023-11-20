using CarImport.Core.Repository_Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Repository
{
    public class OrderRepository<T>: BaseRepository<Order>, IOrderRepository<Order>
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
