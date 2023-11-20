using CarImport.Core.Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Repository
{
    public class CustomerRepository<T> : BaseRepository<Customer>, ICustomerRepository<Customer>
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
