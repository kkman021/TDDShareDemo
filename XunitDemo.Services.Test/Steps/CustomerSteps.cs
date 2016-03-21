using System;
using FluentAssertions;
using TechTalk.SpecFlow;
using XunitDemo.Entity;

namespace XunitDemo.Services.Test.Steps
{
    [Binding]
    [Scope(Feature = "Customer")]
    public class CustomerSteps
    {
        private CustomerService _target;

        [BeforeScenario]
        public void BeforeScenario()
        {
            this._target = new CustomerService(new FakeNorthwindDbContext());
        }

        [Given(@"我輸入第一個數字 (.*)")]
        public void Given我輸入第一個數字(int firstNumber)
        {
            ScenarioContext.Current.Set<int>(firstNumber, nameof(firstNumber));
        }

        [Given(@"我輸入第二個數字 (.*)")]
        public void Given我輸入第二個數字(int secondNumber)
        {
            ScenarioContext.Current.Set<int>(secondNumber, nameof(secondNumber));
        }

        [When(@"我呼叫Add方法")]
        public void When我呼叫Add方法()
        {
            var firstNumber = ScenarioContext.Current.Get<int>("firstNumber");
            var secondNumber = ScenarioContext.Current.Get<int>("secondNumber");

            var actual = _target.Add(firstNumber, secondNumber);

            ScenarioContext.Current.Set<int>(actual, nameof(actual));
        }

        [Then(@"Add方法要等於 (.*)")]
        public void ThenAdd方法要等於(int expect)
        {
            var actual = ScenarioContext.Current.Get<int>("actual");

            expect.Should().Be(actual);
        }
    }
}
