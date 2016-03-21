using System.Collections.Generic;
using XunitDemo.Entity;

namespace XunitDemo.Services
{
    public interface ICustomerService
    {
        int Add(int firstNumber, int secondNumber);
        List<Customer> GetCustomers(string city);
    }
}