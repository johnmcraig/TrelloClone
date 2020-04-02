using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TrelloClone.Infrastructure;
using TrelloClone.Models;

namespace TrelloClone.Data
{
    public class TrelloCloneDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
      public TrelloCloneDbContext(DbContextOptions<TrelloCloneDbContext> options)
            : base(options)
      {
      }

      public DbSet<Board> Boards { get; set; }
      public DbSet<Card> Cards { get; set; }

    }
}
