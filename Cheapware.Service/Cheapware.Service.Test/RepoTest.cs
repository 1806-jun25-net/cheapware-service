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
        
        //[Fact]
        //public async void AddCustomerToDatabaseTest()
        //{
        //    var mockSet = new Mock<DbSet<Customers>>();

        //    var mockContext = new Mock<CheapWareContext>();
        //    mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

        //    var service = new ComputerRepo(mockContext.Object);
        //    service.AddCustomer(new Customer { CustomerName = "Test Name", Address = "Test Address" });
        //    await service.Save();

        //    mockContext.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once);
        //    mockContext.Verify( m => m.SaveChangesAsync(), Times.Once());
        //}


        //[Fact]
        //public async void GetCustomerFromDatabaseTest()
        //{
        //    var data = new List<Customers>
        //    {
        //        new Customers{UserName = "test1username", Address = "test1 Address", CustomerName = "test1 Name"},
        //        new Customers{UserName = "test2username", Address = "test2 Address", CustomerName = "test2 Name"},
        //        new Customers{UserName = "test3username", Address = "test3 Address", CustomerName = "test3 Name"}
        //    };

        //    var mockSet = new Mock<DbSet<Customers>>();

        //    mockSet.As<IQueryable<Customers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<CheapWareContext>();
        //    mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

        //    var service = new ComputerRepo(mockContext.Object);
        //    var customers = await service.GetCustomers();

        //    Assert.Equal(3, customers.Count);
        //    Assert.Equal("test1username", customers[0].UserName);
        //    Assert.Equal("test2username", customers[1].UserName);
        //    Assert.Equal("test3username", customers[2].UserName);
        //}

        //[Fact]
        //public async void GetInventorysFromDatabaseTest()
        //{
        //    var data = new List<Inventorys>
        //    {
        //        new Inventorys{Name = "test1name", Quantity = 50, Category = "CPU", Price = 129.99M},
        //        new Inventorys{Name = "test2name", Quantity = 50, Category = "RAM", Price = 129.99M},
        //        new Inventorys{Name = "test3name", Quantity = 50, Category = "Harddrive", Price = 129.99M},
        //    };

        //    var mockSet = new Mock<DbSet<Inventorys>>();

        //    mockSet.As<IQueryable<Inventorys>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<CheapWareContext>();
        //    mockContext.Setup(m => m.Inventorys).Returns(mockSet.Object);

        //    var service = new ComputerRepo(mockContext.Object);
        //    var inventorys = await service.GetInventory();

        //    Assert.Equal(3, inventorys.Count);
        //    Assert.Equal("test1name", inventorys[0].Name);
        //    Assert.Equal("test2name", inventorys[1].Name);
        //    Assert.Equal("test3name", inventorys[2].Name);
        //}

    //    [Fact]
    //    public async void GetRAMsFromDatabaseTest()
    //    {
    //        var data = new List<Rams>
    //        {
    //            new Rams{Name = "test1name", Size = "test1 size", Speed = "test1 speed", Price = 129.99M},
    //            new Rams{Name = "test2name", Size = "test2 size", Speed = "test2 speed", Price = 12.99M},
    //            new Rams{Name = "test3name", Size = "test3 size", Speed = "test3 speed", Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<Rams>>();

    //        mockSet.As<IQueryable<Rams>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.Rams).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var Rams = await service.GetRams();

    //        Assert.Equal(3, Rams.Count);
    //        Assert.Equal("test1name", Rams[0].Name);
    //        Assert.Equal("test2name", Rams[1].Name);
    //        Assert.Equal("test3name", Rams[2].Name);
    //    }

    //    [Fact]
    //    public async void GetCPUsFromDatabaseTest()
    //    {
    //        var data = new List<Cpus>
    //        {
    //            new Cpus{Name = "test1name", Cores = 4, Speed = "test1 speed", Price = 129.99M},
    //            new Cpus{Name = "test2name", Cores = 3, Speed = "test2 speed", Price = 12.99M},
    //            new Cpus{Name = "test3name", Cores = 8, Speed = "test3 speed", Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<Cpus>>();

    //        mockSet.As<IQueryable<Cpus>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.Cpus).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var cpus = await service.GetCpus();

    //        Assert.Equal(3, cpus.Count);
    //        Assert.Equal("test1name", cpus[0].Name);
    //        Assert.Equal("test2name", cpus[1].Name);
    //        Assert.Equal("test3name", cpus[2].Name);
    //    }

    //    [Fact]
    //    public async void GetGraphicsCardsFromDatabaseTest()
    //    {
    //        var data = new List<GraphicsCards>
    //        {
    //            new GraphicsCards{Name = "test1name", Size = "8GB", Speed = "test1 speed", Price = 129.99M},
    //            new GraphicsCards{Name = "test2name", Size = "8GB", Speed = "test2 speed", Price = 12.99M},
    //            new GraphicsCards{Name = "test3name", Size = "8GB", Speed = "test3 speed", Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<GraphicsCards>>();

    //        mockSet.As<IQueryable<GraphicsCards>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.GraphicsCards).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var graphicscards = await service.GetGraphicsCards();

    //        Assert.Equal(3, graphicscards.Count);
    //        Assert.Equal("test1name", graphicscards[0].Name);
    //        Assert.Equal("test2name", graphicscards[1].Name);
    //        Assert.Equal("test3name", graphicscards[2].Name);
    //    }

    //    [Fact]
    //    public async void GetHardDrivesFromDatabaseTest()
    //    {
    //        var data = new List<HardDrives>
    //        {
    //            new HardDrives{Name = "test1name", Size = "500GB", Speed = "test1 speed", Price = 129.99M},
    //            new HardDrives{Name = "test2name", Size = "500GB", Speed = "test2 speed", Price = 12.99M},
    //            new HardDrives{Name = "test3name", Size = "500GB", Speed = "test3 speed", Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<HardDrives>>();

    //        mockSet.As<IQueryable<HardDrives>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.HardDrives).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var harddrives = await service.GetHardDrives();

    //        Assert.Equal(3, harddrives.Count);
    //        Assert.Equal("test1name", harddrives[0].Name);
    //        Assert.Equal("test2name", harddrives[1].Name);
    //        Assert.Equal("test3name", harddrives[2].Name);
    //    }

    //    [Fact]
    //    public async void GetMotherBoardsFromDatabaseTest()
    //    {
    //        var data = new List<MotherBoards>
    //        {
    //            new MotherBoards{Name = "test1name", FormFactor = "ATX", Pcislots = 4, Ramslots = 4, Price = 129.99M},
    //            new MotherBoards{Name = "test2name", FormFactor = "ATX", Pcislots = 3, Ramslots = 4, Price = 12.99M},
    //            new MotherBoards{Name = "test3name", FormFactor = "ATX", Pcislots = 8, Ramslots = 4, Price = 120.99M}
    //        };

    //        var mockSet = new Mock<DbSet<MotherBoards>>();

    //        mockSet.As<IQueryable<MotherBoards>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.MotherBoards).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var motherboards = await service.GetMotherBoards();

    //        Assert.Equal(3, motherboards.Count);
    //        Assert.Equal("test1name", motherboards[0].Name);
    //        Assert.Equal("test2name", motherboards[1].Name);
    //        Assert.Equal("test3name", motherboards[2].Name);
    //    }

    //    [Fact]
    //    public async void GetComputerCasesFromDatabaseTest()
    //    {
    //        var data = new List<ComputerCases>
    //        {
    //            new ComputerCases{Name = "test1name", Size = "Full Tower", Price = 129.99M},
    //            new ComputerCases{Name = "test2name", Size = "Mid Tower", Price = 12.99M},
    //            new ComputerCases{Name = "test3name", Size = "Mini Tower", Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<ComputerCases>>();

    //        mockSet.As<IQueryable<ComputerCases>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.ComputerCases).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var computercases = await service.GetComputerCases();

    //        Assert.Equal(3, computercases.Count);
    //        Assert.Equal("test1name", computercases[0].Name);
    //        Assert.Equal("test2name", computercases[1].Name);
    //        Assert.Equal("test3name", computercases[2].Name);
    //    }

    //    [Fact]
    //    public async void GetPowerSupplysFromDatabaseTest()
    //    {
    //        var data = new List<PowerSupplys>
    //        {
    //            new PowerSupplys{Name = "test1name", Wattage = "500W", Modular = true, Price = 129.99M},
    //            new PowerSupplys{Name = "test2name", Wattage = "600W", Modular = false, Price = 12.99M},
    //            new PowerSupplys{Name = "test3name", Wattage = "400W", Modular = true, Price = 120.99M}

    //        };

    //        var mockSet = new Mock<DbSet<PowerSupplys>>();

    //        mockSet.As<IQueryable<PowerSupplys>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        var mockContext = new Mock<CheapWareContext>();
    //        mockContext.Setup(m => m.PowerSupplys).Returns(mockSet.Object);

    //        var service = new ComputerRepo(mockContext.Object);
    //        var powersupply = await service.GetPowerSupplys();

    //        Assert.Equal(3, powersupply.Count);
    //        Assert.Equal("test1name", powersupply[0].Name);
    //        Assert.Equal("test2name", powersupply[1].Name);
    //        Assert.Equal("test3name", powersupply[2].Name);
    //    }

    }
}
