﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

/*

    單元測試3A原則
    
    Arrange : 初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
    Act : 呼叫目標物件的方法。
    Assert : 驗證是否符合預期。
    
    參考來源：https://dotblogs.com.tw/hatelove/2012/11/07/learning-tdd-in-30-days-day3-how-to-write-a-unit-test-code
*/
namespace XunitDemo.Services.Test
{
    public class Customer
    {
        [Fact]
        public void Add_1加1等於2()
        {
            //arrange
            var targetService = new CustomerService();

            var firstNumber = 1;
            var secondNumber = 1;
            var expected = 2;

            //act
            int actual = targetService.Add(firstNumber, secondNumber);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_會員_城市在London_返回6筆資料()
        {
            //arrange
            var targetService = new CustomerService();

            var city = "London";
            var expectedRecordCount = 6;

            //act
            var actual = targetService.GetCustomers(city);

            //assert
            Assert.Equal(expectedRecordCount, actual.Count);
        }
    }
}
