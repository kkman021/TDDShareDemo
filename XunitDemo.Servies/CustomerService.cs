using System.Collections.Generic;
using System.Linq;
using XunitDemo.Entity;

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
            var db = new NorthwindDbContext();

            var customers = db.Customers.Where(x => x.City == city).ToList();

            return customers;
        }
    }
}