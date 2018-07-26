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
            Category = i.Category
        };
        public static data.Inventorys Map(Inventory i) => new data.Inventorys
        {
            Name = i.Name,
            Quantity = i.Quantity,
            Price = i.Price,
            Category = i.Category
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

        


    }
}
