using CarImport.Core.Models.Order;
using CarImport.Domain.DbEntities;
using CarImport.Infrastructure.Enumerations;
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
        Task<Order> GetOrderById(int Id);

     //   Task<Currencies> GetCurrency(Currencies currency);
        Task<List<Order>> GetAllOrders();
    }
}
