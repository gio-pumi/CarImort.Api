using CarImport.Core.Models.Search;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Interfaces
{
    public interface ISearchCustomerService
    {
        Task<List<Customer>> GetCustomers (SearchCustomerDTO searchCustomerDTO);
    }
}
