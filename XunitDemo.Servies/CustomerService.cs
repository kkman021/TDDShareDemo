using System.Collections.Generic;

namespace XunitDemo.Services
{
    public class CustomerService
    {
        
        public CustomerService()
        {
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public List<Entity.Customer> GetCustomers(string city)
        {
            throw new System.NotImplementedException();
        }
    }
}