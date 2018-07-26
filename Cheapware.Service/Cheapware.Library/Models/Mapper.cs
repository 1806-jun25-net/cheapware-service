using System;
using System.Collections.Generic;
using System.Text;
using data = Cheapware.Data.Models;

namespace Cheapware.Library.Models
{
    public static class Mapper
    {
        public static Customer Map(data.Customers c) => new Customer
        {
            CustomerId = c.CustomerId,
            CustomerName = c.CustomerName,
            Address = c.Address
        };
        public static data.Customers Map(Customer c) => new data.Customers
        {
            CustomerId = c.CustomerId,
            CustomerName = c.CustomerName,
            Address = c.Address
            
        };

        public static Inventory Map(data.Inventorys i) => new Inventory
        {
            Name = i.Name,
            Quantity = i.Quantity,
            Price = i.Price,
            Category = i.Category,
            Img = i.Img
        };
        public static data.Inventorys Map(Inventory i) => new data.Inventorys
        {
            Name = i.Name,
            Quantity = i.Quantity,
            Price = i.Price,
            Category = i.Category,
            Img = i.Img
        };

        public static PartsOrder Map(data.PartsOrders p) => new PartsOrder
        {
            OrderId = p.OrderId,
            CustomerId = p.CustomerId,
            TimeOfOrder = p.TimeOfOrder,
            FinalPrice = p.FinalPrice
        };
        public static data.PartsOrders Map(PartsOrder p) => new data.PartsOrders
        {
            OrderId = p.OrderId,
            CustomerId = p.CustomerId,
            TimeOfOrder = p.TimeOfOrder,
            FinalPrice = p.FinalPrice
        };

        public static MotherBoard Map(data.MotherBoards m) => new MotherBoard
        {
            MotherBoardId = m.MotherBoardId,
            Name = m.Name,
            FormFactor = m.FormFactor,
            Price = m.Price,
            Pcislots = m.Pcislots,
            Ramslots = m.Ramslots,
            Img = m.Img

        };
        public static data.MotherBoards Map(MotherBoard m) => new data.MotherBoards
        {
            MotherBoardId = m.MotherBoardId,
            Name = m.Name,
            FormFactor = m.FormFactor,
            Price = m.Price,
            Pcislots = m.Pcislots,
            Ramslots = m.Ramslots,
            Img = m.Img
        };

        public static ComputerCase Map(data.ComputerCases c) => new ComputerCase
        {
            ComputerCaseId = c.ComputerCaseId,
            Name = c.Name,
            Size = c.Size,
            Price = c.Price,
            Image = c.Img
        };
        public static data.ComputerCases Map(ComputerCase c) => new data.ComputerCases
        {
            ComputerCaseId = c.ComputerCaseId,
            Name = c.Name,
            Size = c.Size,
            Price = c.Price,
            Img = c.Image
        };

        public static CPU Map(data.Cpus c) => new CPU
        {
            CPUId = c.Cpuid,
            Name = c.Name,
            Image = c.Img,
            Speed = c.Speed,
            Cores = c.Cores

        };
        public static data.Cpus Map(CPU c) => new data.Cpus
        {
            Cpuid = c.CPUId,
            Name = c.Name,
            Img = c.Image,
            Speed = c.Speed,
            Cores = c.Cores

        };

        public static RAM MAP(data.Rams r) => new RAM
        {
            RAMId = r.Ramid,
            Name = r.Name,
            Image = r.Img,
            Speed = r.Speed,
            Size = r.Size,
            Price = r.Price


        };
        public static data.Rams MAP(RAM r) => new data.Rams
        {
            Ramid = r.RAMId,
            Name = r.Name,
            Img = r.Image,
            Speed = r.Speed,
            Size = r.Size,
            Price = r.Price


        };

        public static GraphicsCard Map(data.GraphicsCards g) => new GraphicsCard
        {
            GraphicsCardId = g.GraphicsCardId,
            Name = g.Name,
            Image = g.Img,
            Size = g.Size,
            Price = g.Price,
            Speed = g.Speed
            
        };

        public static HardDrive Map(data.HardDrives h) => new HardDrive
        {
            HardDriveId = h.HardDriveId,
            Name = h.Name,
            Speed = h.Speed,
            Category = h.Category,
            Price = h.Price,
            Img = h.Img
        };
        public static data.HardDrives Map(HardDrive h) => new data.HardDrives
        {
            HardDriveId = h.HardDriveId,
            Name = h.Name,
            Speed = h.Speed,
            Category = h.Category,
            Price = h.Price,
            Img = h.Img
        };

        public static PowerSupply Map(data.PowerSupplys p) => new PowerSupply
        {
            PowerSupplyId = p.PowerSupplyId,
            Name = p.Name,
            Image = p.Img,
            Modular = p.Modular,
            Wattage = p.Wattage,
            Price = p.Price

        };

        public static data.PowerSupplys Map(PowerSupply p) => new data.PowerSupplys
        {
            PowerSupplyId = p.PowerSupplyId,
            Name = p.Name,
            Img = p.Image,
            Modular = p.Modular,
            Wattage = p.Wattage,
            Price = p.Price

        };









    }
}
