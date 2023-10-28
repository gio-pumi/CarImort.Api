using CarImport.Core.Models.Order;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Interfaces
{
    public interface IOrderService 
    {
        Task<List<Order>> AddOrder(OrderDTO orderDTO);
        Task<List<Order>> UpdateOrder(OrderUpdateDTO orderDTO);
        Task<List<Order>> DeleteOrder(int Id);
        Task<Order> GetOrderByID(int Id);
        Task<List<Order>> GetAllOrders();
    }
}
