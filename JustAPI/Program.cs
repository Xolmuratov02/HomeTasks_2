var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    var message = $"{DateTime.Now:u} request path - {context.Request.Path} with method {context.Request.Method}";

    await using var fileStream = File.Open("log.txt", FileMode.Append, FileAccess.Write);
    await using var streamWriter = new StreamWriter(fileStream);
    await streamWriter.WriteLineAsync(message);

    await next();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
