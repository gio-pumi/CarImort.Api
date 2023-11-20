using AutoMapper;
using CarImport.Core.Interfaces;
using CarImport.Core.Models.Customer;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository<Customer> _customerRepository;
        private readonly ICustomerService _customerService; 

        public CustomerController(ICustomerService customerService, ICustomerRepository<Customer> customerRepository, IMapper mapper)
        {
            _customerService = customerService;
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<List<CustomerDTO>> AddCustomer(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            var customers = await _customerRepository.AddAsync(customer);
            var customersDTO = _mapper.Map<List<CustomerDTO>>(customers);   
            return customersDTO;
        }

        [HttpPut]
        public async Task<List<CustomerDTO>> UpdateCustomer(CustomerUpdateDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            var customers = await _customerRepository.UpdateAsync(customer);

            var customersDTO = _mapper.Map<List<CustomerDTO>>(customers);  
            return customersDTO;
        }
        
        [HttpDelete]
        public async Task<List<CustomerDTO>> DeleteCustomer(int id)
        {
            var customers = await _customerRepository.DeleteAsync(id);

            var  customersDTO = _mapper.Map<List<CustomerDTO>>(customers);

            return customersDTO;
        }


        [HttpGet]
        [Route("{customerId}")]

        public async Task<CustomerDTO> GetCustomerByID(int Id)
        {
            var customer = await _customerRepository.GetByIdAsync(Id);
            var customerDTO = _mapper.Map<CustomerDTO>(customer);

            return customerDTO;
        }

        //[HttpGet]
        //public async Task<List<CustomerDTO>> GetAllCustomers()
        //{
        //    var customers = await _customerRepository.GetAllAsync();
        //    var customersDTO =_mapper.Map<List<CustomerDTO>>(customers);

        //    return customersDTO;
        //}


        [HttpGet("customers")]
        public async Task<IActionResult> GetCustomers(bool? sortBy, [FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
        {
            var result = await _customerService.GetCustomers(pageIndex,pageSize,sortBy);
                return Ok(result);
        }
    }
}
