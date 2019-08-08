using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloClone.Models;

namespace TrelloClone.Data
{
    public class TrelloCloneDbContext : DbContext
    {
      public TrelloCloneDbContext(DbContextOptions<TrelloCloneDbContext> options)
            : base(options)
      {
      }

      public DbSet<Board> Boards { get; set; }

    }
}
