using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FluentAssertions;
using NSubstitute;
using NSubstitute.Core;
using Xunit;
using XunitDemo.Entity;
using XunitDemo.Services;
using XunitDemo.Web.Controllers;

namespace XUnitDemo.Web.Test.Controllers
{
    public class CustomerControllerTests
    {

        [Fact()]
        public void IndexTest()
        {
            //arrange
            var city = "";
            var customerService = Substitute.For<ICustomerService>();
            var expectErrorMsg = "請輸入居住地";

            //act
            var target = new CustomerController(customerService);
            var actul = target.Index(city) as ViewResult;
            var actulErrorMsg = actul.ViewBag.ErrorMsg as string;

            //assert
            actulErrorMsg.Should().Be(expectErrorMsg);
            customerService.Received(0).GetCustomers(city);
        }

        [Fact()]
        public void IndexTest_city_Lodon_nodatereturn()
        {
            //arrange
            var city = "Lodon";
            var customerService = Substitute.For<ICustomerService>();

            //模擬回傳的資料
            customerService.GetCustomers(city).Returns(new List<Customer>());

            var expectErrorMsg = "查無資料";

            //act
            var target = new CustomerController(customerService);
            var actul = target.Index(city) as ViewResult;
            var actulErrorMsg = actul.ViewBag.ErrorMsg as string;

            //assert
            actulErrorMsg.Should().Be(expectErrorMsg);
            customerService.Received(1).GetCustomers(city);
        }
    }
}