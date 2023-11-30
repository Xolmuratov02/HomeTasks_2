using N75.Configurations;
using N75.Models.Entities;
using N75.Services;

var builder = WebApplication.CreateBuilder(args);
await builder.ConfigureAsync();

var app = builder.Build();

app.MapPost("api/users",
    async (User user, AccountAggregatorService accountService) => { await accountService.CreateAsync(user); });

await app.ConfigureAsync();
await app.RunAsync();