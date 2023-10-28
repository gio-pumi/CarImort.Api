using CarImport.Core.Interfaces;
using CarImport.Core.Models.Customer;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarImport.Core.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ApplicationDbContext _db;

        public CustomerService(ApplicationDbContext context)
        {
            _db = context;
        }



        // Add Customer to db
        public async Task<List<Customer>> AddCustomer(CustomerDTO customerDTO)
        {

            var customer = new Customer()
            {
                PersonalNumber = customerDTO.PersonalNumber,
                Name = customerDTO.Name,
                LastName = customerDTO.LastName,
                BirthDate = customerDTO.BirthDate
            };

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
            customer.CreateDate = DateTime.Now;
            customer.ModifierUser = "Gior PUMI4";
            customer.LastModifyDate = DateTime.Now;
            customer.LastModifierUser = "Gio pumi4";


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


    }
}
