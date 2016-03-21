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
using XUnitDemo.Web.Test.PagedObject;

namespace XUnitDemo.Web.Test.Controllers
{
    public class CustomerControllerTests : FluentTest, IDisposable
    {
        private LoginPage _loginPage;

        public CustomerControllerTests()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            this._loginPage = new LoginPage(this);
        }

        [Fact]
        public void Index_Login_Selenium_Fail()
        {
            var accountName = "test";
            var password = "12";
            var expectMsg = "帳號密碼異常";

            //.Go為FluentTest預設提供的方法，不需自己寫
            _loginPage.Go();

            _loginPage.EnterAccount(accountName);
            _loginPage.EnterPwd(password);
            _loginPage.ClickLogin();
            _loginPage.ShouldShowErrorMsg(expectMsg);
        }
    }
}