using CarImport.Core.Interfaces;
using CarImport.Core.Models.Order;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Route("")]
       // [Authorize(Roles ="Admin")]
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
            var result = await _orderService.GetOrderByID(Id);

            return result;
        }

        [HttpGet]
        [Route("")]
      //  [Authorize(Roles="User")]
        public async Task<List<Order>> GetAllOrders()
        {
            var result = await _orderService.GetAllOrders();

            return result;
        }

    }
}
