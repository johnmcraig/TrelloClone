using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
      public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
      {
      }

      public DbSet<Board> Boards { get; set; }
      public DbSet<Card> Cards { get; set; }

    }
}
