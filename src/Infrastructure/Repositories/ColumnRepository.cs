using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Application
{
    public class ColumnRepository
    {
        private readonly StoreContext _dbContext;

        public ColumnRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
