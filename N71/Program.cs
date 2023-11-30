using Microsoft.EntityFrameworkCore;
using N71.DataContexts;

var options = new DbContextOptionsBuilder<LibraryDbContext>();
options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=3325");

options.LogTo(Console.WriteLine);

var dbContext = new LibraryDbContext(options.Options);

var authorToDelete = dbContext.Authors.OrderBy(author => author.Id).FirstOrDefault() ?? throw new InvalidOperationException();

Console.WriteLine("test");

var yetauthorToDelete = dbContext.Authors.OrderBy(author => author.Id).FirstOrDefault() ?? throw new InvalidOperationException();

Console.WriteLine(yetauthorToDelete.Name);

dbContext.Remove(authorToDelete);

await dbContext.SaveChangesAsync();