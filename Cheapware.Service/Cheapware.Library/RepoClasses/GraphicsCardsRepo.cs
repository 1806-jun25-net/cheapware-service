using System;
using System.Collections.Generic;
using System.Text;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace Cheapware.Library.RepoClasses
{
    public class GraphicsCardsRepo
    {
        private readonly CheapWareContext db;

        public GraphicsCardsRepo(CheapWareContext _db)
        {
            db = _db;
        }
        public List<GraphicsCard> GetGraphicsCards()
        {
            return Mapper.Map(db.GraphicsCards);
        }
        public GraphicsCard GetGraphicsCardByName(string name)
        {
            var cards = db.GraphicsCards;
            foreach(var card in cards)
            {
                if (card.Name == name)
                    return Mapper.Map(card);
            }
            return null;
        }
    }
}
