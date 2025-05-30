using System;
using Microsoft.AspNetCore.Identity;

namespace UCK.Api.Models.Users
{
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
