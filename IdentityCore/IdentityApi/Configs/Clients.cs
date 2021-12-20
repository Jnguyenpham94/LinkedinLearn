using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityApi.Configs
{
    public static class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClientId",
                    ClientName = "This is my first Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>{new Secret("secret".Sha256()) },
                    AllowedScopes = new List<string>{"customAPI.read"}
                }
            };
        }
    }
}
