using AutoMapper;
using CarImport.Core.Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using CarImport.Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;


namespace CarImport.Core.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CustomerService(ApplicationDbContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;

        }


        public async Task<PaginatedData<Customer>> GetCustomers(int pageIndex, int pageSize, bool? isAsc)
        {
            var query = _db.Customers.AsQueryable();

            if (isAsc != null)
            {
                if (isAsc.Value)
                {
                    query = query.OrderBy(c => c.Name);
                }
                else
                {
                    query = query.OrderByDescending(c => c.Name);
                }
            }

            var totalItems = await _db.Customers.CountAsync();
            var customers = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PaginatedData<Customer>
            {
                TotalItems = totalItems,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Items = customers
            };
        }
    }
}

