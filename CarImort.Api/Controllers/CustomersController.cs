using CarImport.Core.Interfaces;
using CarImport.Core.Models.Customer;
using CarImport.Core.Services;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<List<Customer>> AddCustomer(CustomerDTO customerDTO)
        {

            var result = await _customerService.AddCustomer(customerDTO);

            return result;
        }
        [HttpPut]

        public async Task<List<Customer>> UpdateCustomer(CustomerUpdateDTO customerDTO)
        {
            var result = await _customerService.UpdateCustomer(customerDTO);

            return result;
        }

        [HttpDelete]
        public async Task<List<Customer>> DeleteCustomer(int Id)
        {
            var result = await _customerService.DeleteCustomer(Id);

            return result;
        }


        [HttpGet]
        [Route("{customerId}")]

        public async Task<Customer> GetCustomerByID(int Id)
        {
            var result = await _customerService.GetCustomerByID(Id);

            return result;
        }

        [HttpGet]
        public async Task<List<Customer>> GetAllCustomers()
        {
            var result = await _customerService.GetAllCustomers();

            return result;
        }

    }
}
