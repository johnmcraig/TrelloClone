using System;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
    }
}