using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloClone.Data;
using TrelloClone.ViewModel;

namespace TrelloClone.Services
{
    public class BoardService
    {
        private readonly TrelloCloneDbContext _dbContext;

        public BoardService(TrelloCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BoardList ListBoard()
        {
            var model = new BoardList();

            foreach (var board in _dbContext.Boards)
            {
                model.Boards.Add(new BoardList.Board
                {
                    Id = board.Id,
                    Title = board.Title
                });
            }
            
            return model;
        }

        public BoardView GetBoard(int id)
        {
            var model = new BoardView();

            var board = _dbContext.Boards
                .Include(b => b.Columns)
                .ThenInclude(c => c.Cards)
                .SingleOrDefault(x => x.Id == id);

            if (board != null)
            {
                model.Id = board.Id;

                foreach (var column in board.Columns)
                {
                    var modelColumn = new BoardView.Column
                    {
                        Title = column.Title
                    };

                    foreach (var card in column.Cards)
                    {
                        var modelCard = new BoardView.Card
                        {
                            Content = card.Contents
                        };

                        modelColumn.Cards.Add(modelCard);
                    }

                    model.Columns.Add(modelColumn);
                }
            }

            return model;
        }

        public void AddCard(AddCard viewModel)
        {
            var board = _dbContext.Boards
                .Include(b => b.Columns)
                .SingleOrDefault(x => x.Id == viewModel.Id);

            if (board != null)
            {
                var firstColumn = board.Columns.FirstOrDefault();

                if (firstColumn == null)
                {
                    firstColumn = new Models.Column
                    {
                        Title = "Todo"
                    };

                    board.Columns.Add(firstColumn);
                }

                firstColumn.Cards.Add(new Models.Card
                {
                    Contents = viewModel.Contents
                });
            }

            _dbContext.SaveChanges();
        }

        public void AddBoard(NewBoard viewModel)
        {
            _dbContext.Boards.Add(new Models.Board {
                Title = viewModel.Title
            });

            _dbContext.SaveChanges();
        }
    }
}
