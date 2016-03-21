using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation;

namespace XUnitDemo.Web.Test.PagedObject
{
    //Page Object必須繼承Page Object
    public class LoginPage : PageObject<LoginPage>
    {
        private const string AccountContainer = "#Account";
        private const string PasswordContainer = "#Pwd";
        private const string ErrormsgContainer = ".validation-summary-errors";

        public LoginPage(FluentTest test) : base(test)
        {
            //定義測試網址Url
            Url = "http://localhost:39765/Home/Login";
        }

        internal void EnterAccount(string accountName)
        {
            I.Enter(accountName).In(AccountContainer);
        }

        internal void EnterPwd(string password)
        {
            I.Enter(password).In(PasswordContainer);
        }

        internal void ClickLogin()
        {
            I.Append(OpenQA.Selenium.Keys.Enter).To(PasswordContainer);
        }

        internal void ShouldShowErrorMsg(string expectMsg)
        {
            I.Assert.True(() => I.Find(ErrormsgContainer).Element.Text.Contains(expectMsg));
        }
    }
}
