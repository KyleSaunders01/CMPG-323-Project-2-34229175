using Microsoft.AspNetCore.Mvc;
using Project_2_34229175.Models;
using Project_2_34229175.Services;

namespace Project_2_34229175.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            try
            {
                var result = orderService.GetOrders();

                return Ok(result);
                
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }


        [HttpGet("{orderId}")]
        public IActionResult GetOrderById(short orderId)
        {
            try
            {
                var result = orderService.GetOrderById(orderId);

                return Ok(result);
                
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpGet("by-customer/{customerId}")]
        public IActionResult GetOrdersByCustomerId(short customerId)
        {
            try
            {
                var result = orderService.GetOrderByCustomerId(customerId);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddOrder(Order newOrder)
        {
            try
            {
                var result = orderService.AddOrder(newOrder);

                return Ok(result);
                
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpPatch]
        public IActionResult UpdateOrderDetails(Order newOrder)
        {
            try
            {
                var result = orderService.UpdateOrderDetails(newOrder);
                
                return Ok(result);
                
            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteOrder(short id)
        {
            try
            {
                var result = orderService.DeleteOrder(id);

                return Ok(result);

            }
            catch (ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }


    }
}
