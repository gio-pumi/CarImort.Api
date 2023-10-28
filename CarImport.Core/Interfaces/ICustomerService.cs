using CarImport.Core.Models.Customer;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> AddCustomer(CustomerDTO customerDTO);
        Task<List<Customer>> UpdateCustomer(CustomerUpdateDTO customerDTO);
        Task<List<Customer>> DeleteCustomer(int Id);
        Task<Customer> GetCustomerByID(int Id);
        Task<List<Customer>> GetAllCustomers();
    }
}
