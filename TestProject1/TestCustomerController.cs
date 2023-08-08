using Microsoft.EntityFrameworkCore;
using Navtech;
using Navtech.Controllers;
using Navtech.Data;

namespace TestProject1
{
    public class TestCustomerController
    {
        Customer cus = new Customer();
        [Fact]
        public void TestSuccessCreateCustomer()
        {
            cus.customerId = 1;
            cus.mobileNumber = "9812345612";
            cus.firstName = "abc";
            cus.lastName = "xyz";
            cus.address = "New Delhi";
            cus.email = "xyz@hotmail.com";

            var options = new DbContextOptionsBuilder<DataContextCustomer>()
            .UseInMemoryDatabase(databaseName: "CustomerDatabase")
            .Options;


            using (var context = new DataContextCustomer(options))
            {
                CustomerController control = new CustomerController(context);
                var response =control.addCustomer(cus);
                Assert.NotNull(response);

                // Assert.Equal(3, movies.Count);
            }
        }
    
    }

}

        
   