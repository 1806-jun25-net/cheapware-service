using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Data.Models;
using Cheapware.Library.Models;

namespace Cheapware.Library.RepoClasses
{
    public class PowerSupplysRepo
    {
        private readonly CheapWareContext db;

        public PowerSupplysRepo(CheapWareContext _db)
        {
            db = _db;
        }

        public List<PowerSupply> GetPowerSupplys()
        {
            return Mapper.Map(db.PowerSupplys);
        }
        public PowerSupply GetPowerSupplyByName(string name)
        {
            var pSupplys = db.PowerSupplys;
            foreach(var pSupply in pSupplys)
            {
                if (pSupply.Name == name)
                    return Mapper.Map(pSupply);
            }
            return null;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
