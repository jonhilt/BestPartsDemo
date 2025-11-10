using BestPartsDemo.Components;
using BestPartsDemo.Data;
using BestPartsDemo.Services;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using Tailwind;

AppContext.SetSwitch("Microsoft.AspNetCore.Components.Routing.NavLink.EnableMatchAllForQueryStringAndFragment", true);

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options => options.DisconnectedCircuitRetentionPeriod = TimeSpan.Zero);

builder.Services.AddDbContextFactory<ContactDbContext>(options =>
    options.UseInMemoryDatabase("ContactsDb"));

builder.Services.AddScoped<IContactService, ContactService>();

// uncomment this to enable Hybrid cache using Redis
// (you will need to run the BestPartsDemo.AppHost Aspire project for this to work)

// builder.AddRedisClient(connectionName: "cache");
//
// builder.Services.AddStackExchangeRedisCache(options =>
// {
//     options.Configuration = builder.Configuration.GetConnectionString("cache");
//     options.InstanceName = "BestPartsDemo_";
// });
//
// builder.Services.AddHybridCache();

builder.Services.AddValidation();

builder.UseTailwindCli();

var app = builder.Build();

app.MapDefaultEndpoints();

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