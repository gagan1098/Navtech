﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Navtech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class CustomerController : ControllerBase
    {
        private readonly DataContextCustomer _context;

        public CustomerController(DataContextCustomer context)
        {
            _context = context;
                
        }
        

        [HttpPost]
        public async Task<ActionResult<List<Order>>> addCustomer(Customer cs)
        {
            var query = (from p in _context.customers where p.email == cs.email select p).ToList();
            if (query.Count() != 0)
            {
                return BadRequest("This e-mail is already registered");

            }




            _context.customers.Add(cs);
            await _context.SaveChangesAsync();
            return Ok("Customer has been created");




        }
    }
}
