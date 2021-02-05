using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;
using TrelloClone.Infrastructure;
using TrelloClone.Models;

namespace TrelloClone.Data
{
    public class TrelloCloneDbContext :
        IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
      private readonly IConfiguration _config;

      public TrelloCloneDbContext(DbContextOptions<TrelloCloneDbContext> options, 
        IConfiguration config) : base(options)
      {
          _config = config;
      }

      public DbSet<Board> Boards { get; set; }
      public DbSet<Card> Cards { get; set; }
      public DbSet<Column> Columns { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
          base.OnModelCreating(builder);

          builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      }
    }
}
