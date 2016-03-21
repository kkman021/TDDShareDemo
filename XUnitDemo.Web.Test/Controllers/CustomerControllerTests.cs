using FluentAutomation;
using System;
using Xunit;
using XUnitDemo.Web.Test.PagedObject;

namespace XUnitDemo.Web.Test.Controllers
{
    public class CustomerControllerTests : FluentTest, IDisposable
    {
        private readonly LoginPage _loginPage;

        public CustomerControllerTests()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            _loginPage = new LoginPage(this);
        }

        [Fact(Skip = "Undo")]
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