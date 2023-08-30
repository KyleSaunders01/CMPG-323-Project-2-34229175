using Project_2_34229175.Context;
using Project_2_34229175.Models;

namespace Project_2_34229175.Services
{
    public class ProductService
    {
        private readonly P2DevContext _context;

        public ProductService(P2DevContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var result = _context.Products.AsEnumerable();
            if (result.Count() == 0)
            {
                throw new ArgumentException("There are no Products in the system");
            }
            else
            {
                return result;
            }
        }

        public Product GetProductById(short id)
        {
            var result = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (CheckProduct(id) == null)
            {
                throw new ArgumentException("The Product doesn't exist in the system");
            }
            else
            {
                return result;
            }
        }

        public IEnumerable<Product> GetProductsByOrderId(short orderId)
        {
            if(_context.Orders.Find(orderId) == null)
            {
                throw new ArgumentException("The Order doesn't exist in the system");
            }
            else
            {
                var result = _context.OrderDetails
                    .Where(x => x.OrderId == orderId)
                    .Select(c => c.Product)
                    .ToList();

                return result;
            }
        }

        public Product AddProduct(Product product)
        {
            var result = _context.Products.Add(product);

            _context.SaveChanges();
            return result.Entity;
        }

        public Product UpdateProduct(Product product)
        {
            if (CheckProduct(product.ProductId) == null)
            {
                throw new Exception("The Product doesn't exist in the system");
            }
            else
            {
                var existingProduct = _context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductDescription = product.ProductDescription;
                existingProduct.UnitsInStock = product.UnitsInStock;

                _context.SaveChanges();
                return existingProduct;
            }
        }

        public Product DeleteProduct(short id)
        {
            if (CheckProduct(id) == null)
            {
                throw new ArgumentException("The Product doesn't exist in the system");
            }
            else
            {
                var result = _context.Products.Remove(CheckProduct(id));
                _context.SaveChanges();
                return result.Entity;
            }
        }

        private Product CheckProduct(short id)
        {
            var findProduct = _context.Products.Find(id);
            if (findProduct != null)
            {
                return findProduct;
            }
            else
            {
                return null;
            }
        }
    }
}
