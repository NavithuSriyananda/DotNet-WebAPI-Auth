# DotNet-WebAPI-Auth

Authentication and authorization are two critical concepts in the context of information security, particularly when it comes to accessing systems, applications, and data. They serve different purposes but often work together to protect resources.

## Authentication - Verify identity (401 Unauthorized)
> Authentication is the process of verifying the identity of a user, device, or other entity. The goal of authentication is to ensure that the entity requesting access is who or what it claims to be.

**Common Methods of Authentication:**
1. Passwords: The most common form of authentication, where a user provides a secret password that matches the stored credentials.
2. Biometric Authentication: Uses unique biological characteristics (fingerprints, facial recognition, retina scans) to verify identity.
3. Two-Factor Authentication (2FA) / Multi-Factor Authentication (MFA): Combines two or more different types of authentication (e.g., password and a code sent to a mobile device) for enhanced security.
4. Tokens: Physical or digital devices (e.g., smart cards, USB tokens) that generate or store authentication information.
5. Certificates: Digital certificates issued by a trusted authority that verify the identity of the user or device.

## Authorization - Verify authenticated user permissions/claims/policies (403 Forbidden)
> Authorization is the process of determining whether an authenticated entity is allowed to access a specific resource or perform a specific action. Authorization occurs after authentication and defines what an authenticated entity can do.

**Common Models of Authorization:**
1. Role-Based Access Control (RBAC): Access rights are assigned based on roles within an organization. Each role has a set of permissions that determines what actions users in that role can perform.
2. Access Control Lists (ACLs): Specific permissions are assigned to individual users or groups for specific resources.
3. Attribute-Based Access Control (ABAC): Access rights are granted based on attributes (e.g., user role, department, time of day, etc.) and policies that use these attributes to make decisions.
4. Policy-Based Access Control: Uses a set of policies to manage and enforce rules for access to resources, often in dynamic and complex environments.

## Key Differences:
**Purpose:**
- Authentication: Confirms identity.
- Authorization: Determines permissions.

**Sequence:**
- Authentication: Happens first; ensures the entity is who it claims to be.
- Authorization: Happens after authentication; defines what the authenticated entity can access or do.

**Scope:**
- Authentication: Typically involves the user or device.
- Authorization: Involves access control policies and permissions related to resources.

> In summary, authentication is about verifying identity, while authorization is about granting the appropriate level of access based on that verified identity. Both are essential components of a secure system.

## Projects

1. Basic Authentication and Authorization
	- Project Name: BasicAuth
	- Description: Implement basic authentication and role-based authorization in a .NET Web API. Demonstrate how to secure endpoints with [Authorize] attribute and how to handle user roles.
2. JWT Authentication
	- Project Name: JWTAuth
	- Description: Implement JSON Web Token (JWT) authentication. Show how to generate JWT tokens, validate them, and use them for securing API endpoints. Include role-based authorization using claims in the JWT.
3. OAuth2 and OpenID Connect
	- Project Name: OAuth2OpenID
	- Description: Implement OAuth2 and OpenID Connect using an external provider (e.g., Google, Microsoft). Demonstrate how to integrate external login, token management, and API protection.
4. Two-Factor Authentication (2FA)
	- Project Name: TwoFactorAuth
	- Description: Add two-factor authentication to a .NET Web API using SMS or email-based OTP (One-Time Password) verification. Show the process of enrolling for 2FA and validating the second factor during login.
5. API Key Authentication
	- Project Name: APIKeyAuth
	- Description: Implement API key authentication for a .NET Web API. Demonstrate how to generate, distribute, and validate API keys. Secure specific endpoints using API keys.
6. Custom Authentication Middleware
	- Project Name: CustomAuthMiddleware
	- Description: Create a custom authentication middleware for a .NET Web API. Show how to build and integrate a middleware that authenticates users based on custom logic (e.g., validating credentials against a database).
7. Role-Based Access Control (RBAC)
	- Project Name: RBAC
	- Description: Implement role-based access control in a .NET Web API. Define roles and permissions, assign roles to users, and protect endpoints based on user roles.
8. Attribute-Based Access Control (ABAC)
	- Project Name: ABAC
	- Description: Implement attribute-based access control in a .NET Web API. Use policies based on user attributes (e.g., department, job title) to authorize access to resources.
9. IdentityServer Integration
	- Project Name: IdentityServerIntegration
	- Description: Integrate IdentityServer for centralized authentication and authorization. Demonstrate how to set up IdentityServer, configure clients, and protect APIs using IdentityServer tokens.
10. Social Login Integration
	- Project Name: SocialLogin
	- Description: Implement social login functionality using providers like Google, Facebook, and GitHub. Show how to authenticate users via social accounts and integrate with a .NET Web API.
11. Token Refresh Mechanism
	- Project Name: TokenRefresh
	- Description: Implement a token refresh mechanism for JWT tokens. Show how to handle token expiration and refresh tokens to maintain user sessions without requiring re-login.


