using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Library.Models;
using Cheapware.Data.Models;
namespace Cheapware.Library.RepoClasses
{
    public class MotherBoardsRepo
    {
        private readonly CheapWareContext db;

        public MotherBoardsRepo(CheapWareContext _db)
        {
            db = _db;
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
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
