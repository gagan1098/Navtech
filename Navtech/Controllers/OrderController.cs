using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Navtech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>()
        {
            new Order
            {
                orderId = 1,
                placedTime = DateTime.Now,
                updatedTime = DateTime.Now,
                items = 2,
                orderStatus = "placed"

            }

        };
        private readonly DataContext _context;
        public OrderController(DataContext context)
        {
            _context = context;
                
        }


        [HttpGet]
        public async Task<IActionResult> get()
        {
            var orders = new List<Order>();
            {
                new Order
                {
                    orderId = 1,
                    orderStatus = "placed",
                    placedTime = DateTime.Now,
                    updatedTime = DateTime.Today,
                    items = 2




                };
            };
            return Ok(orders);


        }

        [HttpPost]
        public async Task<ActionResult<List<Order>>> addOrder(Order od)
        {
            _context.orders.Add(od);
            await _context.SaveChangesAsync();
            return Ok("Order has been created");  
            
           


        }
        
    }
}
