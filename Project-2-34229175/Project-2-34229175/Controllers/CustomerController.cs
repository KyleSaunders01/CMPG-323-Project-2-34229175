using Microsoft.AspNetCore.Mvc;
using Project_2_34229175.Models;
using Project_2_34229175.Services;

namespace Project_2_34229175.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        

        private readonly CustomerService customerService;

        public CustomerController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            try
            {
                var result = customerService.GetCustomers();
                
                return Ok(result);
            }
            catch(ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.ToString());
            }
        }


        [HttpGet("{customerId}")]
        public IActionResult GetCustomerById(short customerId)
        {
            try
            {
                var result = customerService.GetCustomerById(customerId);

                return Ok(result);
                
            }
            catch(ArgumentException ex) 
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer newCustomer)
        {
            try
            {
                var result = customerService.AddCustomer(newCustomer);
                  
                return Ok(result);
              
            }
            catch(ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpPatch]
        public IActionResult UpdateCustomerDetails(Customer newCustomer)
        {
            try
            {
                var result = customerService.UpdateCustomerDetails(newCustomer);

                return Ok(result);
                
            }
            catch(ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(short id)
        {
            try
            {
                var result = customerService.DeleteCustomer(id);

                return Ok(result);
                
            }
            catch(ArgumentException ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }
    }
}
