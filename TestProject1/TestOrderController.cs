using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Navtech.Controllers;
using Navtech.Data;
using Navtech;

namespace TestProject1
{
   
    public class TestOrderController
    {
        Order od = new Order();
        [Fact]
        public void TestSuccessAddOrder()
        {
            od.items = 4;
            od.orderId = 12;
            od.orderStatus = "Placed";


            var options = new DbContextOptionsBuilder<DataContextOrder>()
            .UseInMemoryDatabase(databaseName: "OrderDatabase")
            .Options;


            using (var context = new DataContextOrder(options))
            {
                OrderController control = new OrderController(context);
                var response = control.addOrder(od);
                Assert.NotNull(response);               
            }
        }

    }

}

