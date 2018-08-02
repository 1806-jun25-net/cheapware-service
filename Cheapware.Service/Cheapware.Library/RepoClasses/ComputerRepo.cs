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
        public List<ComputerCase> GetComputerCases()
        {
            return Mapper.Map(db.ComputerCases);
        }

        public ComputerCase GetComputerCaseByName(string name)
        {
            var cases = db.ComputerCases;
            foreach(var cCase in cases)
            {
                if (cCase.Name == name)
                    return Mapper.Map(cCase);
            }
            return null;
        }
        public List<CPU> GetCpus()
        {
            return Mapper.Map(db.Cpus);
        }

        public CPU GetCpuByName(string name)
        {
            var cpus = db.Cpus;
            foreach (var cpu in cpus)
            {
                if (cpu.Name == name)
                    return Mapper.Map(cpu);
            }
            return null;
        }
        public async Task Save()
        {
            await db.SaveChangesAsync();
        }

        public Customer GetCustomerByUserName(string name)
        {
            var users = db.Customers;
            foreach(var user in users)
            {
                if (user.UserName == name)
                    return Mapper.Map(user);
            }
            return null;
        }
        public List<Customer> GetCustomers()
        {
            return Mapper.Map(db.Customers);
        }
        public void AddCustomer(Customer customer)
        {
            db.Add(Mapper.Map(customer));
        }
        public Customer GetCustomerById(int id)
        {
            var customers = db.Customers;
            foreach(var customer in customers)
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
        public List<GraphicsCard> GetGraphicsCards()
        {
            return Mapper.Map(db.GraphicsCards);
        }
        public GraphicsCard GetGraphicsCardByName(string name)
        {
            var cards = db.GraphicsCards;
            foreach (var card in cards)
            {
                if (card.Name == name)
                    return Mapper.Map(card);
            }
            return null;
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
        public List<MotherBoard> GetMotherBoards()
        {
            return Mapper.Map(db.MotherBoards);
        }

        public MotherBoard GetMotherBoardByName(string name)
        {
            var mBoards = db.MotherBoards;
            foreach (var board in mBoards)
            {
                if (board.Name == name)
                {
                    return Mapper.Map(board);
                }
            }
            return null;
        }
        public List<PowerSupply> GetPowerSupplys()
        {
            return Mapper.Map(db.PowerSupplys);
        }
        public PowerSupply GetPowerSupplyByName(string name)
        {
            var pSupplys = db.PowerSupplys;
            foreach (var pSupply in pSupplys)
            {
                if (pSupply.Name == name)
                    return Mapper.Map(pSupply);
            }
            return null;
        }
        public List<RAM> GetRams()
        {
            return Mapper.Map(db.Rams);
        }
        public RAM GetRamByName(string name)
        {
            var rams = db.Rams;
            foreach (var ram in rams)
            {
                if (ram.Name == name)
                    return Mapper.Map(ram);
            }
            return null;
        }
        public async  Task<List<HardDrive>> GetHardDrives()
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
<<<<<<< HEAD
            var cart = db.Carts.FindAsync(id);
            return await Mapper.Map(cart);
=======
            var cart = await db.Carts.FindAsync(id);
            return Mapper.Map(cart);
>>>>>>> c14e891788ed3090b35a9b0206178be47d427366
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
