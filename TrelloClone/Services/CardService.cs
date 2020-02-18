using System.Linq;
using System.Threading.Tasks;
using TrelloClone.Data;
using TrelloClone.ViewModel;

namespace TrelloClone.Services
{
    public class CardService
    {
        private readonly TrelloCloneDbContext _dbContext;

        public CardService(TrelloCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public CardDetails GetDetails(int id)
        {
            var card = _dbContext.Cards.SingleOrDefault(x => x.Id == id);
            if (card == null) return new CardDetails();
            
            return new CardDetails
            {
                Id = card.Id,
                Contents = card.Contents,
                Notes = card.Notes
            };
        }

        public void Update(CardDetails cardDetails)
        {
            var card = _dbContext.Cards.SingleOrDefault(x => x.Id == cardDetails.Id);
            card.Contents = cardDetails.Contents;
            card.Notes = cardDetails.Notes;

            _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var card = _dbContext.Cards.SingleOrDefault(x => x.Id == id);
            _dbContext.Remove(id);
            
            _dbContext.SaveChanges();
        }
        
    }
}