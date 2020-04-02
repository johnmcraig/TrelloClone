using System;
using Microsoft.AspNetCore.Identity;

namespace TrelloClone.Infrastructure
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
    }
}