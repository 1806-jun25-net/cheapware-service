using Cheapware.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using System.Linq;
using System.Threading.Tasks;
namespace Cheapware.Library.RepoClasses
{
    public class ComputerRepo : IComputerRepo
    {
        private readonly CheapWareContext db;

        public ComputerRepo(CheapWareContext _db)
        {
            db = _db;
        } 

        public Cart GetCartById(int id)
        {

            return Mapper.Map(db.Carts.Find(id));
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
        public void Save()
        {
            db.SaveChanges();
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
        public List<Inventory> GetInventory()
        {
            return Mapper.Map(db.Inventorys);
        }
        public Inventory GetProductByName(string name)
        {
            var products = db.Inventorys;
            foreach (var product in products)
            {
                if (product.Name == name)
                    return Mapper.Map(product);
            }
            return null;
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
        public List<HardDrive> GetHardDrives()
        {
            return Mapper.Map(db.HardDrives);
        }
        public HardDrive GetHardDriveByName(string name)
        {
            var hDrives = db.HardDrives;
            foreach(var drive in hDrives)
            {
                if (drive.Name == name)
                    return Mapper.Map(drive);
            }
            return null;
        }
        public List<Inventory> GetInventoryByCategory(string cat)
        {
            var inventory = db.Inventorys;
            List<Inventory> list = new List<Inventory>();
            foreach(var item in inventory)
            {
                if (item.Category == cat)
                    list.Add(Mapper.Map(item));
            }
            return list;
        }

        public List<PartsOrder> GetOrdersByCustomerId(int id)
        {
            List<PartsOrder> list = new List<PartsOrder>();
            var orders = db.PartsOrders;
            foreach(var order in orders)
            {
                if (order.CustomerId == id)
                    list.Add(Mapper.Map(order));
            }
            return list;
        }
        public void AddOrder(PartsOrder order)
        {
            db.Add(Mapper.Map(order));
        }
        public PartsOrder GetOrderById(int id)
        {
            var orders = db.PartsOrders;
            foreach(var order in orders)
            {
                if (order.OrderId == id)
                    return Mapper.Map(order);
            }
            return null;
        }

        public List<Cart> GetCartByCustomerId(int id)
        {
            var carts = db.Carts;
            List<Cart> list = new List<Cart>();
            foreach(var cart in carts)
            {
                if (cart.CustomerId == id)
                    list.Add(Mapper.Map(cart));
            }
            return list;
        }
        public void AddCart(Cart cart)
        {
            db.Add(cart);
        }
    }
}
