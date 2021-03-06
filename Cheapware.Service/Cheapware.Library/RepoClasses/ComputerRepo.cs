﻿using Cheapware.Data.Models;
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
        public async Task<List<Cpu>> GetCpus()
        {
            return Mapper.Map(await db.Cpus.ToListAsync());
        }

        public async Task<Cpu> GetCpuByName(string name)
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
        
        //public async Task<int> GetCustomerIdByUserName(string userName)
        //{
        //    var cust = await db.Customers.Where(x => x.UserName == userName).SingleAsync();
        //    return cust.CustomerId;
        //}
            
           
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
        public async Task<List<Ram>> GetRams()
        {
            return Mapper.Map(await db.Rams.ToListAsync());
        }
        public async Task<Ram> GetRamByName(string name)
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
            var orders = Mapper.Map(await db.Inventorys.Where(x => x.Category == cat).ToListAsync());

            return orders;
        }

        public async Task<List<PartsOrder>> GetOrdersByCustomerId(int id)
        {
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
        public async Task<List<Inventory>> GetInventoryByCart(List<string> items)
        {
            var list = new List<Inventory>();
            foreach(var item in items)
            {
                list.Add(Mapper.Map(await db.Inventorys.FindAsync(item)));
            }
            return list;

        }
        public async Task<List<Inventory>> GetCartByCustomerId(int id)
        {

            var cart = await db.Carts.Where(x => x.CustomerId == id).ToListAsync();
            var list = new List<string>();
            foreach(var item in cart)
            {
                list.Add(item.ProductName);
            }
            List<Inventory> items = await GetInventoryByCart(list);
           
            return items;
        }
        public void AddCart(Cart cart)
        {
            db.Carts.Add(Mapper.Map(cart));
        }
        public async Task DeleteCartByCustomer(int id)
        {
            db.Carts.RemoveRange(await db.Carts.Where(x => x.CustomerId == id).ToListAsync());
        }

        public async Task<List<Inventory>> GetInventoryBySearch(string search = null)
        {

            if (search == null)
            {
                return Mapper.Map(await db.Inventorys.ToListAsync());
            }
            
            return Mapper.Map(await db.Inventorys.Where(x => x.Name.Contains(search)).ToListAsync());
            
        }

        public async Task DeleteByCartId(int cartId)
        {
            db.Carts.Remove(await db.Carts.FindAsync(cartId));
        }

        public async Task<int> GetRecentOrderByCustomerId(int id)
        { 

            var orders = await db.PartsOrders.Where(x => x.CustomerId == id).ToListAsync();

            var orderId = orders.OrderByDescending(x => x.TimeOfOrder).First().OrderId;
            return orderId;
        }

        public void AddJunction(int id, List<Inventory> names)
        {
            foreach(var item in names)
            {
                PartsJunctions pj = new PartsJunctions()
                {
                    OrderId = id,
                    Name = item.Name
                };
                db.PartsJunctions.Add(pj);
            }
        }
        public async Task<List<Cart>> CartIdsByCustomer(int id)
        {
            return Mapper.Map(await db.Carts.Where(x => x.CustomerId == id).ToListAsync());
        }
        public void UpdateInventory(Inventory inv)
        {
             db.Inventorys.Update(Mapper.Map(inv));
        }
    }
}
