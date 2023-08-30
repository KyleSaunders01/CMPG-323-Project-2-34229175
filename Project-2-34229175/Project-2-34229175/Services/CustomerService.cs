using Microsoft.EntityFrameworkCore;
using Project_2_34229175.Context;
using Project_2_34229175.Models;

namespace Project_2_34229175.Services
{
    public class CustomerService
    {
        private readonly P2DevContext _context;

        public CustomerService(P2DevContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var result = _context.Customers
                .Include(c => c.Orders)
                .ToList();

            if (result.Count() == 0)
            {
                throw new ArgumentException("There are no customers in the system");
            }
            else
            {
                return result;
            }
        }

        public Customer GetCustomerById(short id)
        {
            
            if (CheckCustomer(id) == null)
            {
                throw new ArgumentException("The Customer doesn't exist in the system"); ;
            }
            else
            { 
                var result = _context.Customers
                    .Include(c => c.Orders)
                    .FirstOrDefault(c => c.CustomerId == id);

                return result;
            }
        }

        public Customer AddCustomer(Customer customer)
        {
            var result = _context.Customers.Add(customer);
            if (CheckCustomer(customer.CustomerId) != null)
            {
                throw new ArgumentException("The Customer cannot be added to the system");
            }
            else
            {
                _context.SaveChanges();
                return result.Entity;
            }
        }

        public Customer UpdateCustomerDetails(Customer customer)
        {
            if (CheckCustomer(customer.CustomerId) == null)
            {
                throw new ArgumentException("The Customer doesn't exist in the system");
            }
            else
            {
                var existingCustomer = _context.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);

                // Update properties of existingCustomer with values from customer
                existingCustomer.CustomerTitle = customer.CustomerTitle;
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.CustomerSurname = customer.CustomerSurname;
                existingCustomer.CellPhone = customer.CellPhone;
                _context.SaveChanges();
                return existingCustomer;
            }
        }

        public Customer DeleteCustomer(short id)
        {
            if (CheckCustomer(id) == null)
            {
                throw new ArgumentException("The Customer doesn't exist in the system");
            }
            else
            {
                var result = _context.Customers.Remove(CheckCustomer(id));
                _context.SaveChanges();
                return result.Entity;
            }
        }

        private Customer CheckCustomer(short id)
        {
            var findCustomer = _context.Customers.Find(id);
            if (findCustomer != null)
            {
                return findCustomer;
            }
            else
            {
                return null;
            }
        }
    }
}
