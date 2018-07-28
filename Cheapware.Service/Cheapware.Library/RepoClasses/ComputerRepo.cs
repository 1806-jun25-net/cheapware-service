﻿using Cheapware.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;

namespace Cheapware.Library.RepoClasses
{
    public class ComputerRepo
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
        public void Save()
        {
            db.SaveChanges();
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

    }
}