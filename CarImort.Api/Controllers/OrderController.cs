using AutoMapper;
using CarImport.Core.Models.Order;
using CarImport.Core.Repository_Interfaces;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Mvc;

namespace CarImort.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository<Order> _orderRepository;
        private readonly IMapper _mapper;
        public OrderController(IOrderRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<List<OrderDTO>> AddOrder(OrderDTO orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            var orders = await _orderRepository.AddAsync(order);
            var ordersDTO = _mapper.Map<List<OrderDTO>>(orders);

            return ordersDTO;
        }

        [HttpPut]
        public async Task<List<OrderDTO>> UpdateOrder(OrderUpdateDTO orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            var orders = await _orderRepository.UpdateAsync(order);
            var ordersDTO = _mapper.Map<List<OrderDTO>>(orders);

            return ordersDTO;
        }

        [HttpDelete]
        public async Task<List<OrderDTO>> DeleteOrder(int Id)
        {
            var orders = await _orderRepository.DeleteAsync(Id);
            var OrdersDTO = _mapper.Map<List<OrderDTO>>(orders);

            return OrdersDTO;
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<OrderDTO> GetOrderByID(int Id)
        {
            var orders = await _orderRepository.GetByIdAsync(Id);
            var OrdersDTO = _mapper.Map<OrderDTO>(orders);
            return OrdersDTO;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<OrderDTO>> GetAllOrders()
        {
            var orders = _orderRepository.GetAllAsync();
            var OrdersDTO = _mapper.Map<List<OrderDTO>>(orders);

            return OrdersDTO;
        }

    }
}
