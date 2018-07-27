using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace Cheapware.Library.RepoClasses
{
    public class RamsRepo
    {
        private readonly CheapWareContext db;

        public RamsRepo(CheapWareContext _db)
        {
            db = _db;
        }

        public List<RAM> GetRams()
        {
            return Mapper.Map(db.Rams);
        }
        public RAM GetRamByName(string name)
        {
            var rams = db.Rams;
            foreach(var ram in rams)
            {
                if (ram.Name == name)
                    return Mapper.Map(ram);
            }
            return null;
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
