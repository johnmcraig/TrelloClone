using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain.Entities;
using TrelloClone.ViewModel;

namespace Application
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
            var card = _dbContext
                .Cards
                .Include(c => c.Column)
                .SingleOrDefault(x => x.Id == id);

            if (card == null) 
                return new CardDetails();
           
            // retrieve boards
            var board = _dbContext
                .Boards
                .Include(b => b.Columns)
                .SingleOrDefault(x => x.Id == card.Column.BoardId);

            // map board columns
            if (board != null) 
            {
                var availableColumns = board
                    .Columns
                    .Select(x => new SelectListItem
                    {
                        Text = x.Title,
                        Value = x.Id.ToString()
                    });


                return new CardDetails
                {
                    Id = card.Id,
                    Contents = card.Contents,
                    Notes = card.Notes,
                    Columns = availableColumns.ToList(), // list available columns
                    Column = card.ColumnId // map current column
                };
            }
            return null;
        }

        public void Update(CardDetails cardDetails)
        {
            var card = _dbContext.Cards.SingleOrDefault(x => x.Id == cardDetails.Id);
            if (card != null)
            {
                card.Contents = cardDetails.Contents;
                card.Notes = cardDetails.Notes;
                card.ColumnId = cardDetails.Column;
            }

            _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var card = _dbContext.Cards.SingleOrDefault(x => x.Id == id);
            _dbContext.Remove(card ?? throw new Exception($"Could not remove {(Card) null}"));
            
            _dbContext.SaveChanges();
        }
        
    }
}