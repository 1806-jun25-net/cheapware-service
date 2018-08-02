using Cheapware.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cheapware.Library.RepoClasses
{
    public class ComputerRepo : IComputerRepo
    {
        private readonly CheapWareContext db;

        public ComputerRepo(CheapWareContext _db)
        {
            db = _db;
        } 
        public async Task<List<ComputerCase>> GetComputerCases()
        {
            return Mapper.Map(await db.ComputerCases.ToListAsync());
        }

        public async Task<ComputerCase> GetComputerCaseByName(string name)
        {
            return Mapper.Map(await db.ComputerCases.Where(x => x.Name == name).SingleAsync());
        }
        public async Task<List<CPU>> GetCpus()
        {
            return Mapper.Map(await db.Cpus.ToListAsync());
        }

        public async Task<CPU> GetCpuByName(string name)
        {
            return Mapper.Map(await db.Cpus.Where(x => x.Name == name).SingleAsync());
        }
        public async Task Save()
        {
            await db.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomerByUserName(string name)
        {
            return Mapper.Map(await db.Customers.Where(x => x.UserName == name).SingleAsync());
        }
        public async Task<List<Customer>> GetCustomers()
        {
            return Mapper.Map(await db.Customers.ToListAsync());
        }
        public void AddCustomer(Customer customer)
        {
            db.Add(Mapper.Map(customer));
        }
        public async Task<Customer> GetCustomerById(int id)
        {
            return Mapper.Map(await db.Customers.FindAsync(id));
        }
            
            
           
        public async Task<Customer> GetCustomerByName(string name)
        {
            return Mapper.Map(await db.Customers.Where(x => x.CustomerName == name).SingleAsync());
        }
        public async Task<List<GraphicsCard>> GetGraphicsCards()
        {
            return Mapper.Map(await db.GraphicsCards.ToListAsync());
        }
        public async Task<GraphicsCard> GetGraphicsCardByName(string name)
        {
            return Mapper.Map(await db.GraphicsCards.Where(x => x.Name == name).SingleAsync());
        }
        public async Task<List<Inventory>> GetInventory()
        {
            var inv = Mapper.Map(await db.Inventorys.ToListAsync());
            return inv;
        }
        public async Task<Inventory> GetProductByName(string name)
        {
            return Mapper.Map(await db.Inventorys.FindAsync(name));
        }
        public async Task<List<MotherBoard>> GetMotherBoards()
        {
            return Mapper.Map(await db.MotherBoards.ToListAsync());
        }

        public async Task<MotherBoard> GetMotherBoardByName(string name)
        {
            return Mapper.Map(await db.MotherBoards.Where(x => x.Name == name).SingleAsync());
        }
        public async Task<List<PowerSupply>> GetPowerSupplys()
        {
            return Mapper.Map(await db.PowerSupplys.ToListAsync());
        }
        public async Task<PowerSupply> GetPowerSupplyByName(string name)
        {
            return Mapper.Map(await db.PowerSupplys.Where(x => x.Name == name).SingleAsync());
        }
        public async Task<List<RAM>> GetRams()
        {
            return Mapper.Map(await db.Rams.ToListAsync());
        }
        public async Task<RAM> GetRamByName(string name)
        {
            return Mapper.Map(await db.Rams.Where(x => x.Name ==name).SingleAsync());
        }
        public async Task<List<HardDrive>> GetHardDrives()
        { 
            return Mapper.Map(await db.HardDrives.ToListAsync());
        }
        public async Task<HardDrive> GetHardDriveByName(string name)
        {
            return Mapper.Map(await db.HardDrives.Where(x => x.Name == name).SingleAsync());
        }
        public async Task<List<Inventory>> GetInventoryByCategory(string cat)
        {
            var getInventoryTasks = new List<Task<Inventory>>();

            var orders = Mapper.Map(await db.Inventorys.Where(x => x.Category == cat).ToListAsync());

            return orders;
        }

        public async Task<List<PartsOrder>> GetOrdersByCustomerId(int id)
        {
            var getOrderTasks = new List<Task<PartsOrder>>();

            var orders = Mapper.Map(await db.PartsOrders.Where(x => x.CustomerId == id).ToListAsync());

            return orders;
        }
        public void AddOrder(PartsOrder order)
        {
            db.Add(Mapper.Map(order));
        }


        public async Task<PartsOrder> GetOrderById(int id)
        {
            var order = await db.PartsOrders.FindAsync(id);
            return Mapper.Map(order);
        }


        public async Task<Cart> GetCartById(int id)
        {
            var cart = await db.Carts.FindAsync(id);
            return Mapper.Map(cart);
        }

        public async Task<List<Cart>> GetCartByCustomerId(int id)
        {
            var cart = Mapper.Map(await db.Carts.Where(x => x.CustomerId == id).ToListAsync());

            return cart;
        }
        public void AddCart(Cart cart)
        {
            db.Add(cart);
        }
    }
}
