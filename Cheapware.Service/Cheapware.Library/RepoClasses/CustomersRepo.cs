﻿using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using Cheapware.Data.Models;

namespace Cheapware.Library.RepoClasses
{
    public class CustomersRepo
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
        public Customer GetCustomerByName(string name)
        {
            var customers = db.Customers;
            foreach (var customer in customers)
            {
                if (customer.CustomerName == name)
                    return Mapper.Map(customer);
            }
            return null;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
