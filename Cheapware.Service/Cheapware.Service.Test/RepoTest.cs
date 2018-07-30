using Cheapware.Data.Models;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Cheapware.Service.Test
{
    public class RepoTest
    {
        public RepoTest()
        {
            //services.AddScoped<ComputerRepo>();

            //services.AddDbContext<CheapWareContext>(options =>
              //  options.Use(Configuration.GetConnectionString("CheapwareDB")));
        }
        
        [Fact]
        public void GetCustomersShouldReturnAListOfCustomers()
        {

            var customerList = new List<Customer>
            {
                new Customer { CustomerId = 1, Address = "test address 1", CustomerName = "test name"},
                new Customer { CustomerId = 1, Address = "test address 2", CustomerName = "test name 2"}

            };

            


        }
    }
}
