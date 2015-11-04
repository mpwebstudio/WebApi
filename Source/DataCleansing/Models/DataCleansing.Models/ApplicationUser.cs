namespace DataCleansing.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            //if (authenticationType == null)
            //{
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            //}

            //// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            //var userIdentity2 = await manager.CreateIdentityAsync(this, authenticationType);
            //// Add custom user claims here
            //return userIdentity2;

        }
    }
}
