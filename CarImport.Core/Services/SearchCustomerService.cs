using CarImport.Core.Interfaces;
using CarImport.Core.Models.Search;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace CarImport.Core.Services
{
    public class SearchCustomerService : ISearchCustomerService
    {
        ApplicationDbContext _db;

        public SearchCustomerService(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }

        public async Task<List<Customer>> GetCustomers (SearchCustomerDTO searchCustomerDTO)
        {
            IQueryable<Customer> query = _db.Customers;
            query = query.Where(
            c =>
           // c.PersonalNumber == searchCustomerDTO.PersonalNumber ||
            c.Name == searchCustomerDTO.Name ||
            c.LastName == searchCustomerDTO.LastName) ;

            var customer = await query.ToListAsync();

            return customer;
        }
    }
}
