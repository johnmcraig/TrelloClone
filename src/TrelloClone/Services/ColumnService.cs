using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloClone.Data;
using TrelloClone.Models;

namespace TrelloClone.Services
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
