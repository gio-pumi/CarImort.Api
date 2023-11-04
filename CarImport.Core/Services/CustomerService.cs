using AutoMapper;
using CarImport.Core.Interfaces;
using CarImport.Core.Models.Customer;
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



        // Add Customer to db
        public async Task<List<Customer>> AddCustomer(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            customer.CreateDate = DateTime.Now;
            customer.RegisterByUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            customer.LastModifierUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            var customers = await _db.Customers.ToListAsync();
            return customers;
        }

        // Update Customer 
        public async Task<List<Customer>> UpdateCustomer(CustomerUpdateDTO customerDTO)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == customerDTO.Id);

            customer.PersonalNumber = customerDTO.PersonalNumber;
            customer.Name = customerDTO.Name;
            customer.LastName = customerDTO.LastName;
            customer.BirthDate = customerDTO.BirthDate;
            customer.LastModifyDate = DateTime.Now;
            customer.LastModifierUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            _db.Update(customer);
            await _db.SaveChangesAsync();

            var customers = await _db.Customers.ToListAsync();
            return customers;
        }

        //Delete Customer
        public async Task<List<Customer>> DeleteCustomer(int Id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == Id);

            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            var customers = await _db.Customers.ToListAsync();
            return customers;
        }

        //Get CustomerById
        public async Task<Customer> GetCustomerByID(int Id)
        {

            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == Id);

            return customer;
        }

        //Get AllCustomers
        public async Task<List<Customer>> GetAllCustomers()
        {

            return await _db.Customers.ToListAsync();

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

