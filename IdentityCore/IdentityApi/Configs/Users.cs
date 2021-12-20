using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityApi.Configs
{
    public class Users
    {
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
           {
               new TestUser
               {
                   SubjectId = "subject-id",
                   Username = "user",
                   Password = "password",
                   Claims = new List<Claim>
                   {
                       new Claim(JwtClaimTypes.Email, "user@user.com"),
                       new Claim(JwtClaimTypes.Role, "admin")
                   }
               }
           };
        }

    }
}
