using Cheapware.Data.Models;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Microsoft.EntityFrameworkCore;
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
        public void AddCustomerToDatabaseTest()
        {
            //var mockSet = new Mock<DbSet<Customer>>();
            //var mockContext = new Mock<CheapWareContext>();
            //mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            //var service = new ComputerRepo(mockContext.Object);
            //service.AddCustomer(new Customer { CustomerName = "Test Name", Address = "Test Address" });

            //mockSet.Verify(m => m.Add(It.IsAny<Customer>()), Times.Once);
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }
    }
}
