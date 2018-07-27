using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using Cheapware.Data.Models;
namespace Cheapware.Library.RepoClasses
{
    public class CpusRepo
    {
        private readonly CheapWareContext db;

        public CpusRepo(CheapWareContext _db)
        {
            db = _db;
        }

        public List<CPU> GetCpus()
        {
            return Mapper.Map(db.Cpus);
        }

        public CPU GetCpuByName(string name)
        {
            var cpus = db.Cpus;
            foreach(var cpu in cpus)
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

    }
}
