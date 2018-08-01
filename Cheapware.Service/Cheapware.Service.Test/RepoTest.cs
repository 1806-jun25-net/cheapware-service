using Cheapware.Data.Models;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Cheapware.Service.Test
{
    public class RepoTest
    {
        
        [Fact]
        public void AddCustomerToDatabaseTest()
        {
            var mockSet = new Mock<DbSet<Customers>>();

            var mockContext = new Mock<CheapWareContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new ComputerRepo(mockContext.Object);
            service.AddCustomer(new Customer { CustomerName = "Test Name", Address = "Test Address" });
            service.Save();

            mockContext.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void AddGraphicsCardToDatabaseTest()
        {
            var mockSet = new Mock<DbSet<GraphicsCards>>();

            var mockContext = new Mock<CheapWareContext>();
            mockContext.Setup(m => m.GraphicsCards).Returns(mockSet.Object);

            var service = new ComputerRepo(mockContext.Object);
            //service.AddGraphicsCard(new GraphicsCard { Name = "Test Name", Size = "Test size" , Speed = "test speed", Price = 149.99M, Image ="test image link"});
            service.Save();

            mockContext.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void AddRAMToDatabaseTest()
        {
            var mockSet = new Mock<DbSet<Rams>>();

            var mockContext = new Mock<CheapWareContext>();
            mockContext.Setup(m => m.Rams).Returns(mockSet.Object);

            var service = new ComputerRepo(mockContext.Object);
            //service.AddRAM(new RAM { Name = "Test Name", Size = "Test size" , Speed = "test speed", Price = 149.99M, Image ="test image link"});
            service.Save();

            mockContext.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void AddHardDriveToDatabaseTest()
        {
            var mockSet = new Mock<DbSet<HardDrives>>();

            var mockContext = new Mock<CheapWareContext>();
            mockContext.Setup(m => m.HardDrives).Returns(mockSet.Object);

            var service = new ComputerRepo(mockContext.Object);
            //service.AddHardDrive(new HardDrive { Name = "Test Name", Size = "Test size", Speed = "test speed", Price = 149.99M, Img = "test image link" });
            service.Save();

            mockContext.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [Fact]
        public void GetCustomerFromDatabaseTest()
        {
            var data = new List<Customers>
            {
                new Customers{UserName = "test1username", Address = "test1 Address", CustomerName = "test1 Name"},
                new Customers{UserName = "test2username", Address = "test2 Address", CustomerName = "test2 Name"},
                new Customers{UserName = "test3username", Address = "test3 Address", CustomerName = "test3 Name"}
            };

            var mockSet = new Mock<DbSet<Customers>>();

            mockSet.As<IQueryable<Customers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<CheapWareContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            var service = new ComputerRepo(mockContext.Object);
            var customers = service.GetCustomers();

            Assert.Equal(3, customers.Count);
            Assert.Equal("test1username", customers[0].UserName);
            Assert.Equal("test2username", customers[1].UserName);
            Assert.Equal("test3username", customers[2].UserName);
        }
    }
}
