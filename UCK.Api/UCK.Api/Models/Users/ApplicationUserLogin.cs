using System;
using Microsoft.AspNetCore.Identity;

namespace UCK.Api.Models.Users
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
