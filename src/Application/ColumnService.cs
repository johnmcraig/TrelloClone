using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using Domain.Entities;

namespace Application
{
    public class ColumnService
    {
        private readonly TrelloCloneDbContext _dbContext;

        public ColumnService(TrelloCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Column viewModel)
        {
        }

        public void Update(Column column)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
