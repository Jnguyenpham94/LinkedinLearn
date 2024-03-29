﻿using IdentityServer4.Models;
using System.Collections.Generic;
using System.IdentityModel;

namespace IdentityApi.Configs
{
    public static class ConfigResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string>{"role"}
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "customAPI",
                    DisplayName = "Custom API",
                    Description = "Custom API",
                    UserClaims = new List<string>{"role"},
                    ApiSecrets = new List<Secret>{new Secret("secret".Sha256())},
                    //Scopes = new List<Scope>
                    //{
                    //    new Scope("customAPI.read"),
                    //    new Scope("customAPI.write"),
                    //    new Scope("customAPI.update"),
                    //    new Scope("customAPI.delete"),
                    //}
                }
            };
        }
    }
}
