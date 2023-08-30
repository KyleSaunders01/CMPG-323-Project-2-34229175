using Microsoft.EntityFrameworkCore;
using Project_2_34229175.Context;
using Project_2_34229175.Models;

namespace Project_2_34229175.Services
{
    public class OrderService
    {
        private readonly P2DevContext _context;

        public OrderService(P2DevContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            var result = _context.Orders.AsEnumerable();
            if (result.Count() == 0)
            {
                throw new ArgumentException("There are no orders in the system");
            }
            else
            {
                return result;
            }
        }

        public Order GetOrderById(short id)
        {
            
            if (CheckOrder(id) == null)
            {
                throw new ArgumentException("The Order doesn't exist in the system");
            }
            else
            {
                var result = _context.Orders.FirstOrDefault(x => x.OrderId == id);
                return result;
            }
        }

        public Order AddOrder(Order order)
        {
            
            if (CheckOrder(order.OrderId) != null)
            {
                throw new ArgumentException("The Order cannot be added to the system");
            }
            else
            {
                var existingCustomer = _context.Customers.FirstOrDefault(c => c.CustomerId == order.CustomerId);
                order.Customer = existingCustomer;
                var result = _context.Orders.Add(order);

                _context.SaveChanges();
                return result.Entity;
            }
        }

        public Order UpdateOrderDetails(Order order)
        {
            if (CheckOrder(order.OrderId) == null)
            {
                throw new ArgumentException("The Order doesn't exist in the system");
            }
            else
            {
                var existingOrder = _context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);

                existingOrder.OrderDate = order.OrderDate;
                existingOrder.DeliveryAddress = order.DeliveryAddress;

                _context.SaveChanges();
                return existingOrder;
            }
        }

        public Order DeleteOrder(short id)
        {
            if (CheckOrder(id) == null)
            {
                throw new ArgumentException("The Order doesn't exist in the system");
            }
            else
            {
                var result = _context.Remove(CheckOrder(id));
                _context.SaveChanges();
                return result.Entity;
            }
        }

        public IEnumerable<Order> GetOrderByCustomerId(short id)
        {
            if(_context.Customers.Find(id)== null)
            {
                throw new ArgumentException("The Customer doesn't exist in the system");
            }
            else
            {
                var result = _context.Orders
                    .Where(order => order.CustomerId == id)
                    .ToList();

                return result;
            }
        }
        private Order CheckOrder(short id)
        {
            var findOrder = _context.Orders.Find(id);
            if (findOrder != null)
            {
                return findOrder;
            }
            else
            {
                return null;
            }
        }
    }
}
