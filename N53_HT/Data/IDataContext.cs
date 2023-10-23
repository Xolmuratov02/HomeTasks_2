using FileBaseContext.Abstractions.Models.FileSet;
using N53_HT.Models;

namespace N53_HT.Data;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }
    IFileSet<Order, Guid> Orders { get; }
    IFileSet<Bonus, Guid> Bonuses { get; }
    ValueTask SaveChangesAsync();
}