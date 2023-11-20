using CarImport.Core.Models.Customer;
using CarImport.Domain.DbEntities;
using CarImport.Infrastructure.Helpers;

namespace CarImport.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<PaginatedData<Customer>> GetCustomers(int pageIndex, int pageSize,bool? sort);
    }
}
