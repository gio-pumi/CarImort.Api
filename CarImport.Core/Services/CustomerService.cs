using CarImport.Core.Models;
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
    public class CustomerService
    {

        private readonly ApplicationDbContext DB;

        public CustomerService(ApplicationDbContext context)
        {
            DB = context;
        }



        //Add user from DB
        public void addCustomer()
        {
            Customer customerToAdd = new Customer
            {
                CusomerID = "12fgdfgf",
                Name = "pumi",
                LastName = "Jasahi",
                BirthDate =  new DateTime(1992, 11, 13)

                //CusomerID = customerDTO.CustomerID,
                //Name = customerDTO.Name,
                //LastName = customerDTO.LastName,
                //BirthDate = customerDTO.BirthDate,

            };

            DB.Customers.Add(customerToAdd);
            DB.SaveChanges();
        }

    }
}
