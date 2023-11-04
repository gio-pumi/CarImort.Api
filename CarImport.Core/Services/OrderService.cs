using CarImport.Core.Interfaces;
using CarImport.Core.Models.Order;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace CarImport.Core.Services
{
    public class OrderService : IOrderService
    {

        private readonly ApplicationDbContext _db;
        private  readonly IHttpContextAccessor _contextAccessor;

        public OrderService(ApplicationDbContext context, IHttpContextAccessor contextAccessor)
        {
            _db = context;
            _contextAccessor = contextAccessor;
        }


        // Add Order to db
        public async Task<List<Order>> AddOrder(OrderDTO orderDTO)
        {

            var order = new Order()
            {
                CarId = orderDTO.CarId,
                CustomerId = orderDTO.CustomerId,
                Status = orderDTO.Status,
                Details = orderDTO.Details,
                CreateDate = DateTime.Now,
                LastModifierUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                RegisterByUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name
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
            var user = _contextAccessor.HttpContext.User;


            var order = await _db.Orders.FindAsync(orderDTO.Id);
            order.CustomerId = orderDTO.CustomerId;
            order.Status = orderDTO.Status;
            order.Details = orderDTO.Details;
            order.LastModifyDate = DateTime.Now;


            order.LastModifierUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            // order.LastModifierUser = user.Claims.FirstOrDefault(c => c.Type == "nameidentifier")?.Value;

            // order.LastModifierUser = user.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            ////var emailClaim = user.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier" && c.Value.Length>1);

            //if (emailClaim != null)
            //{
            //    order.LastModifierUser = emailClaim.Value;
            //}

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
        public async Task<Order> GetOrderById(int Id)
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
