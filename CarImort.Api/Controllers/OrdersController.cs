using CarImport.Core.Interfaces;
using CarImport.Core.Models.Order;
using CarImport.Domain.DbEntities;
using CarImport.Infrastructure.Enumerations;
using CarImport.Infrastructure.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarImort.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        //private readonly GetCurrenciesController _currentCurrencies;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
           // _currentCurrencies = currentCurrencies;

        }

        [HttpPost]
        [Route("")]
        public async Task<List<Order>> AddOrder(OrderDTO orderDTO)
        {
            var result = await _orderService.AddOrder(orderDTO);

            return result;
        }

        [HttpPut]
        public async Task<List<Order>> UpdateOrder(OrderUpdateDTO orderDTO)
        {
            var result = await _orderService.UpdateOrder(orderDTO);

            return result;
        }

        [HttpDelete]
        public async Task<List<Order>> DeleteOrder(int Id)
        {

            var orders = await _orderService.DeleteOrder(Id);
            return orders;
        }

        [HttpGet]
        [Route("{orderId}")]
        public async Task<Order> GetOrderByID(int Id)

        {
        //    var returnedCurrencies = _currentCurrencies.GetCurrencies().ToString();

        //    var convertedCurrencies = JsonConvert.DeserializeObject<Currency>(returnedCurrencies);

        //    var finalCurreny = "";

        //    foreach (var currency in convertedCurrencies)
        //    {

        //        if (currency.ToString().Contains(currencyForConvert.ToString())) { }
        //        finalCurreny = currency;
        //    }
        //}



                var result = await _orderService.GetOrderById(Id);
                return result;
            

            //var z = new OrderDTO();
            //return z;
        }

    [HttpGet]
    [Route("")]
    public async Task<List<Order>> GetAllOrders()
    {
        var result = await _orderService.GetAllOrders();

        return result;
    }

}
}
