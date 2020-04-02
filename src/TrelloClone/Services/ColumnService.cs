using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloClone.Data;

namespace TrelloClone.Services
{
    public class ColumnService
    {
        private readonly TrelloCloneDbContext _dbContext;

        public ColumnService(TrelloCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
