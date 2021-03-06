# Social/External Logins

## ASP.NET Core MVC / Razor Pages UI

The [Account Module](../Modules/Account.md) has already configured to handle social or external logins out of the box. You can follow the ASP.NET Core documentation to add a social/external login provider to your application.

### Example: Facebook Authentication

Follow the [ASP.NET Core Facebook integration document](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins) to support the Facebook login for your application.

#### Add the NuGet Package

Add the [Microsoft.AspNetCore.Authentication.Facebook](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.Facebook) package to your project. Based on your architecture, this can be `.Web`, `.IdentityServer` (for tiered setup) or `.Host` project.

#### Configure the Provider

Use the `.AddFacebook(...)` extension method in the `ConfigureServices` method of your [module](../Module-Development-Basics.md), to configure the client:

````csharp
context.Services.AddAuthentication()
    .AddFacebook(facebook =>
    {
        facebook.AppId = "...";
        facebook.AppSecret = "...";
        facebook.Scope.Add("email");
        facebook.Scope.Add("public_profile");
    });
````

> It would be a better practice to use the `appsettings.json` or the ASP.NET Core User Secrets system to store your credentials, instead of a hard-coded value like that. Follow the [Microsoft's document](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins) to learn the user secrets usage.