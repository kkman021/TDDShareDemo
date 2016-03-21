using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using FluentAssertions;
using FluentAutomation;
using NSubstitute;
using NSubstitute.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Xunit;
using XunitDemo.Entity;
using XunitDemo.Services;
using XunitDemo.Web.Controllers;

namespace XUnitDemo.Web.Test.Controllers
{
    public class CustomerControllerTests : FluentTest, IDisposable
    {
        private string baseURL;

        public CustomerControllerTests()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            baseURL = "http://localhost:39765/";
        }

        [Fact]
        public void Index_Login_Selenium_Fail()
        {
            var expectMsg = "帳號密碼異常";

            I.Open(baseURL + "/Home/Login");

            I.Enter("test").In("#Account")
             .Enter("245").In("#Pwd");

            I.Click("input[type=\"submit\"]");

            I.Assert.True(() => I.Find(".validation-summary-errors").Element.Text.Contains(expectMsg));
        }
    }
}