using Microsoft.AspNetCore.Mvc;
using Project_2_34229175.Models;
using Project_2_34229175.Services;

namespace Project_2_34229175.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        
        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            try
            {

                var result = productService.GetProducts();

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }
        
        [HttpGet("{productId}")]
        public IActionResult GetProductById(short productId)
        {
            try
            {
                var result = productService.GetProductById(productId);

                return Ok(result);
            }
            catch (ArgumentException ex) 
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }
        [HttpGet("by-order/{orderId}")]
        public IActionResult GetProductsByOrderId(short orderId)
        {
            try
            {
                var result = productService.GetProductsByOrderId(orderId);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                var result = productService.AddProduct(product);

                return Ok(result);
            }
            catch (ArgumentException ex) 
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }

        [HttpPatch]
        public IActionResult UpdateResult(Product product) 
        {
            try
            {
                var result = productService.UpdateProduct(product);

                return Ok(result);
            }
            catch (ArgumentException ex) 
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }

        [HttpDelete]
        public IActionResult DeleteProduct(short productId) 
        {
            try
            {
                var result = productService.DeleteProduct(productId);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }


    }
}
