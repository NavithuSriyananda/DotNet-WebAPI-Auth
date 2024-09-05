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
    public static IEnumerable<ApiScope> ApiScopes =>
    new ApiScope[]
    {
            new ApiScope(name: "api1.read", displayName: "Read data"),
            new ApiScope(name: "api2.write", displayName: "Write data"),
            new ApiScope(name: "api3.delete", displayName: "Delete data")
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
                AllowedScopes =
                {       "api1.read"
                }

            }

        };
}
