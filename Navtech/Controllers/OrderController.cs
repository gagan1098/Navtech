using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Navtech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
       
        private readonly DataContextOrder _context;
        public OrderController(DataContextOrder context)
        {
            _context = context;
           
        }

        [HttpGet]       
        public async Task<ActionResult<List<Order>>> getOrders(int pageIndex, int pageSize)
        {
            pageIndex--;
            if (pageIndex < 0) {
                return BadRequest("Invalid pageIndex entered");

            }


            var query = (from order in _context.orders select order).Skip(pageSize * pageIndex).Take(pageSize).ToList();
            

            return Ok(query);
        }

        [HttpPost]
        public async Task<ActionResult<List<Order>>> addOrder(Order od)
        {
            
            bool isvalidorderstatus = Validations.IsValidOrderStatus(od.orderStatus);
            
            if(isvalidorderstatus==false) {
                return BadRequest("Invalid orderStatus provided");
            }

            try{
                _context.orders.Add(od);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest("OrderId already exists");
            }
            
            return Ok("Order has been created");  
            
        }
        
    }
}
