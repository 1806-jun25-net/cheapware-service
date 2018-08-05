using Cheapware.Data.Models;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xunit;

namespace Cheapware.Service.Test
{
    public class RepoTest
    {

        [Fact]
        public async void AddCustomerToDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                 .UseInMemoryDatabase(databaseName: "AddCustomersFromDatabase")
                 .Options;


            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                service.AddCustomer(new Customer { CustomerName = "test name", Address = "test address", UserName = "test username" });
                await service.Save();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Equal(1, context.Customers.Count());
                Assert.Equal("test name", context.Customers.Single().CustomerName);
            }
        }


        [Fact]
        public async void GetCustomersFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetCustomersFromDatabase")
                .Options;
            var customer = new Customers { CustomerName = "test name", Address = "test address", UserName = "test username" };
            List<Customer> listofcustomers = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(customer);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofcustomers = await service.GetCustomers();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofcustomers);
                Assert.Equal("test name", context.Customers.Single().CustomerName);
            }
        }

        [Fact]
        public async void GetInventorysFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetCustomersFromDatabase")
                .Options;
            var inventory = new Inventorys { Name = "test product", Quantity = 30, Category = "CPUs", Price = 139.99M };
            List<Inventory> listofinventorys = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(inventory);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofinventorys = await service.GetInventory();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofinventorys);
                Assert.Equal("test product", context.Inventorys.Single().Name);
            }
        }

        [Fact]
        public async void GetRAMsFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                 .UseInMemoryDatabase(databaseName: "GetRamsFromDatabase")
                 .Options;
            var ram = new Rams { Name = "test name", Speed = "2600Mhrtz", Size = "16GB", Price = 300.99M };
            List<Ram> listoframs = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(ram);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listoframs = await service.GetRams();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listoframs);
                Assert.Equal("test name", context.Rams.Single().Name);
            }
        }

        [Fact]
        public async void GetCPUsFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetCpusFromDatabase")
                .Options;
            var cpu = new Cpus { Name = "test name", Speed = "3.6 Ghtz", Cores = 6, Price = 413.99M };
            List<Cpu> listofcpus = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(cpu);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofcpus = await service.GetCpus();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofcpus);
                Assert.Equal("test name", context.Cpus.Single().Name);
            }
        }

        [Fact]
        public async void GetGraphicsCardsFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetGraphicscardsFromDatabase")
                .Options;
            var graphicscard = new GraphicsCards { Name = "test name", Speed = "1700 Mghz", Size = "8GB", Price = 300.99M };
            List<GraphicsCard> listofgraphicscards = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(graphicscard);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofgraphicscards = await service.GetGraphicsCards();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofgraphicscards);
                Assert.Equal("test name", context.GraphicsCards.Single().Name);
            }
        }

        [Fact]
        public async void GetHardDrivesFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetHardDrivesFromDatabase")
                .Options;
            var harddrive = new HardDrives { Name = "test name", Category = "SSD", Size = "500GB", Speed = "7200RPM", Price = 100.99M };
            List<HardDrive> listofharddrives = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(harddrive);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofharddrives = await service.GetHardDrives();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofharddrives);
                Assert.Equal("test name", context.HardDrives.Single().Name);
            }
        }

        [Fact]
        public async void GetMotherBoardsFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetMotherBoardsFromDatabase")
                .Options;
            var motherboard = new MotherBoards { Name = "test name", FormFactor = "ATX", Pcislots = 4, Ramslots = 4, Price = 150.99M };
            List<MotherBoard> listofmotherboards = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(motherboard);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofmotherboards = await service.GetMotherBoards();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofmotherboards);
                Assert.Equal("test name", context.MotherBoards.Single().Name);
            }
        }

        [Fact]
        public async void GetComputerCasesFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                 .UseInMemoryDatabase(databaseName: "GetComputerCasesFromDatabase")
                 .Options;
            var computercase = new ComputerCases { Name = "test name", Size = "Mid Tower", Price = 79.99M };
            List<ComputerCase> listofcomputercases = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(computercase);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofcomputercases = await service.GetComputerCases();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofcomputercases);
                Assert.Equal("test name", context.ComputerCases.Single().Name);
            }
        }

        [Fact]
        public async void GetPowerSupplysFromDatabaseTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetPowerSupplysFromDatabase")
                .Options;
            var powersupply = new PowerSupplys { Name = "test name", Modular = false, Price = 129.99M };
            List<PowerSupply> listofpowersupplys = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(powersupply);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofpowersupplys = await service.GetPowerSupplys();
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofpowersupplys);
                Assert.Equal("test name", context.PowerSupplys.Single().Name);
            }
        }

        [Fact]
        public async void GetInventoryByCategoryTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetInventoryByCategoryDatabase")
                .Options;
            var inventory1 = new Inventorys { Name = "test name1", Quantity = 30, Category = "CPU", Price = 129.99M };
            var inventory2 = new Inventorys { Name = "test name2", Quantity = 50, Category = "HardDrive", Price = 129.99M };

            List<Inventory> listofinventorys = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(inventory1);
                context.Add(inventory2);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                listofinventorys = await service.GetInventoryByCategory("CPU");
            }


            using (var context = new CheapWareContext(options))
            {
                Assert.Single(listofinventorys);
                Assert.Equal("test name1", listofinventorys.First().Name);
            }
        }

        [Fact]
        public async void GetRamByNameTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetRamByNameDatabase")
                .Options;
            var ram1 = new Rams { Name = "test name1", Speed = "1700 Mghrtz", Size = "8GB", Price = 110.99M };
            var ram2 = new Rams { Name = "test name2", Speed = "1900 Mghrtz", Size = "16GB", Price = 150.99M };

            Ram ram = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(ram1);
                context.Add(ram2);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                ram = await service.GetRamByName("test name1");
            }

            using (var context = new CheapWareContext(options))
            {

                Assert.Equal("1700 Mghrtz", ram.Speed);
                Assert.Equal("8GB", ram.Size);
                Assert.Equal(110.99M, ram.Price);
            }
        }

        [Fact]
        public async void GetComputerCaseByNameTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetComputerCaseByNameDatabase")
                .Options;
            var computercase1 = new ComputerCases { Name = "test name1", Size = "Mid Tower", Price = 90.99M };
            var computercase2 = new ComputerCases { Name = "test name2", Size = "Full Tower", Price = 105.99M };

            ComputerCase computercase = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(computercase1);
                context.Add(computercase2);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                computercase = await service.GetComputerCaseByName("test name1");
            }

            using (var context = new CheapWareContext(options))
            {  
                Assert.Equal("Mid Tower", computercase.Size);
                Assert.Equal(90.99M, computercase.Price);
            }
        }

        [Fact]
        public async void GetCpusByNameTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetComputerCaseByNameDatabase")
                .Options;
            var cpu1 = new Cpus { Name = "test name1", Cores = 4, Speed = "3.4Ghz", Price = 90.99M };
            var cpu2 = new Cpus { Name = "test name2", Cores = 4, Speed = "3.6Ghz", Price = 100.99M };


            Cpu cpu = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(cpu1);
                context.Add(cpu2);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                cpu = await service.GetCpuByName("test name1");
            }

            using (var context = new CheapWareContext(options))
            {
                Assert.Equal(4, cpu.Cores);
                Assert.Equal("3.4Ghz", cpu.Speed);
                Assert.Equal(90.99M, cpu.Price);
            }
        }

        [Fact]
        public async void GetCustomerByUserNameTest()
        {
            var options = new DbContextOptionsBuilder<CheapWareContext>()
                .UseInMemoryDatabase(databaseName: "GetComputerCaseByNameDatabase")
                .Options;
            var Cust1 = new Customers { CustomerName = "test name1", Address = "Test address1", UserName = "testusername1" };
            var Cust2 = new Customers { CustomerName = "test name2", Address = "Test address2", UserName = "testusername2" };


            Customer cust = null;

            using (var context = new CheapWareContext(options))
            {
                context.Add(Cust1);
                context.Add(Cust2);
                context.SaveChanges();
            }

            using (var context = new CheapWareContext(options))
            {
                var service = new ComputerRepo(context);
                cust = await service.GetCustomerByUserName("testusername1");
            }

            using (var context = new CheapWareContext(options))
            {
                Assert.Equal("test name1", cust.CustomerName);
                Assert.Equal("Test address1", cust.Address);
               
            }
        }
    }
}
