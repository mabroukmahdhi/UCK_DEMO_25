using System;
using Microsoft.AspNetCore.Identity;

namespace UCK.Api.Models.Users
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
