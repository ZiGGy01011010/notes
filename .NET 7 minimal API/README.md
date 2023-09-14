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

Create first EF migration. In Package Manage Console `add-migration` (don't forget to set default project to DataAccess). Then, `update-database`.

Add `MediatR` package to Application project.

Add `MediatR.Extensions.Microsoft.DependencyInjection` package to API project.

In Application project make folders based on features. Inside make next folders: `Queries`, `QueryHandlers`, `Commands`, `CommandHandlers`.

[Command example](CreatePost.cs)

[Command handler example](CreatePostHandler.cs)

[Query example](GetAllPosts.cs)

[Query handler example](GetAllPostsHandler.cs)

In API project add DbContext service, add all repositories services, add MediatR service.