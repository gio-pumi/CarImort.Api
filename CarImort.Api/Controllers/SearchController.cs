using CarImport.Core.Interfaces;
using CarImport.Core.Models.Search;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchCustomerService _searchCustomerService;

        public SearchController(ISearchCustomerService searchCustomerService)
        {
            _searchCustomerService = searchCustomerService;
        }

        [HttpPost]
        [Route("")]
        public async Task<List<Customer>> GetRequestedCustomer(SearchCustomerDTO searchCustomerDTO)
        {
            var result = await _searchCustomerService.GetCustomers(searchCustomerDTO);

            return result;
        }
    }
}
