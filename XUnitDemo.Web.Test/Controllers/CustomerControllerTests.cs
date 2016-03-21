using XunitDemo.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XunitDemo.Services;
using NSubstitute;

namespace XunitDemo.Web.Controllers.Tests
{
    public class CustomerControllerTests
    {

        [Fact()]
        public void IndexTest()
        {
            //arrange
            var city = "";
            var customerService = Substitute.For<ICustomerService>();

            //act
            var target = new CustomerController(customerService);
            target.Index(city);

            //assert
            customerService.Received(1).GetCustomers(city);
        }
    }
}