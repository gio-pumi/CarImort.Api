using CarImport.Core.Interfaces;
using CarImport.Core.Models.Order;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace CarImport.Core.Services
{
    public class OrderService : IOrderService
    {

        private readonly ApplicationDbContext _db;

        public OrderService(ApplicationDbContext context)
        {
            _db = context;
        }


        // Add Order to db
        public async Task<List<Order>> AddOrder(OrderDTO orderDTO)
        {

            var order = new Order()
            {
                CarId = orderDTO.CarId,
                CustomerId = orderDTO.CustomerId,
                Status = orderDTO.Status,
                Details = orderDTO.Details
            };

            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();

            var orders = await _db.Orders.Include(o => o.Car).ToListAsync();
            //var orders = await _db.Orders.Include(o => o.Car).Include(o => o.Customer).ToListAsync();

            return orders;
        }

        // Update Order 
        public async Task<List<Order>> UpdateOrder(OrderUpdateDTO orderDTO)
        {
            var order = await _db.Orders.FindAsync(orderDTO.Id);
            order.CustomerId = orderDTO.CustomerId;
            order.Status = orderDTO.Status;
            order.Details = orderDTO.Details;
            order.CreateDate = DateTime.Now;
            order.ModifierUser = "Gior PUMI4";
            order.LastModifyDate = DateTime.Now;
            order.LastModifierUser = "Gio pumi4";


            _db.Entry(order).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            var orders = await _db.Orders.ToListAsync();
            return orders;
        }

        //Delete Order
        public async Task<List<Order>> DeleteOrder(int Id)
        {

            var order = await _db.Orders.FirstOrDefaultAsync(o => o.Id == Id);

            _db.Orders.Remove(order);
            await _db.SaveChangesAsync();

            var orders = await _db.Orders.ToListAsync();

            return orders;
        }

        //Get OrderById
        public async Task<Order> GetOrderByID(int Id)
        {

            var order = await _db.Orders.FirstOrDefaultAsync(o => o.Id == Id);
            return order;
        }

        //Get AllOrders
        public async Task<List<Order>> GetAllOrders()
        {
            var orders = await _db.Orders.Include(o => o.Car).ToListAsync();

            return orders;

        }

    }

}
