using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Data.Models;
using Cheapware.Library.Models;

namespace Cheapware.Library.RepoClasses
{
    public class InventoryRepo
    {
        private readonly CheapWareContext db;

        public InventoryRepo(CheapWareContext _db)
        {
            db = _db;
        }

        public List<Inventory> GetInventory()
        {
            return Mapper.Map(db.Inventorys);
        }
        public Inventory GetProductByName(string name)
        {
            var products = db.Inventorys;
            foreach(var product in products)
            {
                if (product.Name == name)
                    return Mapper.Map(product);
            }
            return null;
        }
    }
}
