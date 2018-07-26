using Cheapware.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;

namespace Cheapware.Library.RepoClasses
{
    public class ComputerCaseRepo
    {
        private readonly CheapWareContext db;

        public ComputerCaseRepo(CheapWareContext _db)
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
        
    }
}
