## Get started
[Beginners guide video](https://youtu.be/RRrsFE6OXAQ)

Start from clean architecture solution.

Make Domain, DataAccess, Application projects (class library).

Make MinimalAPI project (ASP.NET Core Web API). Set it as startup project.

Make Models in Domain layer.

In DataAccess layer install NuGet packages `Microsoft.EntityFrameworkCore` (or other ORM), `Microsoft.EntityFrameworkCore.SqlServer` (or other database provider obviously). Create `whateverDbContext` class.

In Application layer create abstractions (interfaces) for repositories.

In DataAccess layer create implementation of repositories interfaces.

Add connection string to `appsettings.json` in API project.

Add NuGet packages `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.Tools` to API project.
## DB migrations
Create first EF migration. In Package Manage Console `add-migration` (don't forget to set default project to DataAccess). Then, `update-database`.
## CQRS with MediatR
Add `MediatR` package to Application project.

Add `MediatR.Extensions.Microsoft.DependencyInjection` package to API project.

In Application project make folders based on features. Inside make next folders: `Queries`, `QueryHandlers`, `Commands`, `CommandHandlers`.

[Command example](CreatePost.cs)

[Command handler example](CreatePostHandler.cs)

[Query example](GetAllPosts.cs)

[Query handler example](GetAllPostsHandler.cs)
## Project structure
In API project make Extensions folder. Create [Extensions class](MinimalApiExtensions.cs). Add DbContext service, add all repositories services, add MediatR service.

Call `RegisterServices` method in `Program.cs`.

Add Abstractions folder, and create [IEndpointDefinition](IEndpointDefinition.cs) interface.

Add EndpointDefinitions folder, and create all endpoint definitions [like this](PostEndpointDefinition.cs).

Write `RegisterEndpointDefinitions` method in [MinimalApiExtensions](MinimalApiExtensions.cs) class.

Call `RegisterEndpointDefinitions` method in `Program.cs`.

## Model validation
Make Filters folder in API project. Create [filters](PostValidationFilter.cs)

Add validation to [RegisterEndpoints](PostEndpointDefinition.cs).
## Exceptions in minimal API
Add middleware for exceptions handling to [Program.cs](Program.cs).