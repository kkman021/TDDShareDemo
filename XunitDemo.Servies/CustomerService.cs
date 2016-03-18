using System.Collections.Generic;
using System.Linq;
using XunitDemo.Entity;

namespace XunitDemo.Services
{
    public class CustomerService
    {
        private readonly INorthwindDbContext _db;
        
        public CustomerService(INorthwindDbContext db)
        {
            this._db = db;
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public List<Entity.Customer> GetCustomers(string city)
        {
            var customers = this._db.Customers.Where(x => x.City == city).ToList();

            return customers;
        }
    }
}