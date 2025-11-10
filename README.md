# .NET 10 Blazor - The Best Parts Demo

A Blazor Server demo application showcasing a simple CRM (Customer Relationship Management) system built with .NET 10.

## Overview

The demo includes:

- Interactive server-side rendering
- Entity Framework Core with in-memory database
- Optional Redis caching with Hybrid Cache (for storing persistent component state)
- .NET Aspire integration for distributed application orchestration
- TailwindCSS for styling

## Project Structure

Three projects:

- **BestPartsDemo** - Main Blazor Server application
- **BestPartsDemo.AppHost** - .NET Aspire orchestrator for local development
- **BestPartsDemo.ServiceDefaults** - Shared service configuration

## Getting Started

### Prerequisites

- .NET 10 SDK
- Visual Studio 2022/26 or JetBrains Rider
- (Optional) Docker Desktop - required only if testing Redis caching

### Running the Application

#### Standard Mode (Without Redis)

Simply run the `BestPartsDemo` project:

```bash
dotnet run --project BestPartsDemo
```

The application will use an in-memory database and run without caching.

#### With Redis Caching (Optional, requires Docker)

If you want to test the Redis caching functionality:

1. **Uncomment the Redis configuration** in `BestPartsDemo/Program.cs` (lines 25-33):

```csharp
builder.AddRedisClient(connectionName: "cache");

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("cache");
    options.InstanceName = "BestPartsDemo_";
});

builder.Services.AddHybridCache();
```

2. **Launch using .NET Aspire** by running the `BestPartsDemo.AppHost` project:

```bash
dotnet run --project BestPartsDemo.AppHost
```

This will start the Aspire dashboard and orchestrate both the application and Redis container.


## Branch Structure

This repository demonstrates the migration to .NET 10:

- **`master`** - Contains the current, up-to-date code with .NET 10 fixes applied
- **`after`** - Shows the "after" state with code upgraded to .NET 10 (same as master)
- *(Historical)* A "before" branch showing some issues (in the pre-.NET 10 state)

**Note:** The `master` branch contains the fully updated .NET 10 version with all compatibility fixes applied.

## Key Features Demonstrated

### Blazor Server Components
- Interactive server-side rendering with `@rendermode InteractiveServer`
- Form validation

### Caching (Optional)
- Hybrid Cache implementation
- Redis distributed caching via .NET Aspire
- StackExchange.Redis integration

### Styling
- TailwindCSS integration via `Tailwind.Extensions.AspNetCore`
- Responsive grid layouts
- Custom component styling

### .NET 10 Compatibility
- `MapStaticAssets()` for optimized static file serving

## Technologies Used

- .NET 10
- Blazor Server
- Entity Framework Core
- .NET Aspire
- Redis (optional)
- TailwindCSS
- Microsoft.Extensions.Caching.Hybrid

## Notes

- The application uses an in-memory database that is seeded with sample contacts on startup
- A simulated 500ms delay is added to demonstrate loading states
- Redis caching is completely optional and commented out by default
- When using Aspire, the dashboard provides observability for the application

## License

This is a demo project for educational and demonstration purposes.