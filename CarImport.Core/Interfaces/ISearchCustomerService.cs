using CarImport.Core.Models.Search;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Interfaces
{
    public interface ISearchCustomerService
    {
        Task<List<Customer>> GetCustomers (SearchCustomerDTO searchCustomerDTO);
    }
}
