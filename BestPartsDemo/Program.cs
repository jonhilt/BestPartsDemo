using BestPartsDemo.Components;
using BestPartsDemo.Data;
using BestPartsDemo.Services;
using Microsoft.EntityFrameworkCore;
using Tailwind;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register EF Core with in-memory database
builder.Services.AddDbContext<ContactDbContext>(options =>
    options.UseInMemoryDatabase("ContactsDb"));

// Register contact service
builder.Services.AddScoped<IContactService, ContactService>();

builder.UseTailwindCli();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Ensure the database is created and seeded
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ContactDbContext>();
    context.Database.EnsureCreated();
}

app.Run();