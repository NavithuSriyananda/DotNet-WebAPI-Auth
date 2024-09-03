using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;

namespace OAuth2OpenID.IdentityServer;

public static class Config
{

    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource()
            {
                Name = "verification",
                UserClaims = new List<string>
                {
                    JwtClaimTypes.Email,
                    JwtClaimTypes.EmailVerified
                }
            }
        };

    //public static IEnumerable<ApiScope> ApiScopes =>
    //    new ApiScope[]
    //    {
    //        new ApiScope(name: "read", displayName: "Read data"),
    //        new ApiScope(name: "write", displayName: "Write data"),
    //        new ApiScope(name: "delete", displayName: "Delete data")
    //    };
    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource(name: "api1", displayName: "Read API")
            {
                Scopes = { "api1.read" }
            },
            new ApiResource(name: "api2", displayName: "Write API")
            {
                Scopes = { "api2.write" }
            },
            new ApiResource(name: "api3", displayName: "Delete API")
            {
                Scopes = { "api3.delete" }
            },
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "OAuth2OpenID.WebAPI",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("OAuth2OpenID.WebAPI".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = { "api1.read" }

            },
            new Client
                {
                    ClientId = "oidc_client",
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("oidc_secret".Sha256()) },
                    RedirectUris = { "https://localhost:5002/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1.read"
                    },
                    AllowOfflineAccess = true
                }

        };
}
