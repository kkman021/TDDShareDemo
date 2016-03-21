using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using FluentAssertions;
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
    public class CustomerControllerTests : IDisposable
    {
        private IWebDriver driver;
        private string baseURL;

        public CustomerControllerTests()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:39765/";
        }

        public void Index_Login_Selenium_Fail()
        {
            driver.Navigate().GoToUrl(baseURL + "/Home/Login");
            driver.FindElement(By.Id("Account")).Clear();
            driver.FindElement(By.Id("Account")).SendKeys("test");
            driver.FindElement(By.Id("Pwd")).Clear();
            driver.FindElement(By.Id("Pwd")).SendKeys("245");
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();

            var expectMsg = "帳號密碼異常";
            var acturlMsg = driver
                            .FindElement(By.CssSelector("div.validation-summary-errors > ul > li"))
                            .Text;

            expectMsg.Should().Be(acturlMsg);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}