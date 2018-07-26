using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using Cheapware.Data.Models;

namespace Cheapware.Library.RepoClasses
{
    class CustomersRepo
    {
        private readonly CheapWareContext db;

        public CustomersRepo(CheapWareContext _db)
        {
            db = _db;
        }

        public List<Customer> GetCustomers()
        {
            return Mapper.Map(db.Customers);
        }
        public void AddCustomer(Customer customer)
        {
            db.Add(customer);
        }
        public Customer GetCustomerById(int id)
        {
            var customers = db.Customers;
            foreach (var customer in customers)
            {
                if (customer.CustomerId == id)
                    return Mapper.Map(customer);
            }
            return null;
        }
    }
}
