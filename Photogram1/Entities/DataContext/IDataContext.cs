using FileBaseContext.Abstractions.Models.FileSet;
using Photogram1.Models;

namespace Photogram1.Entities.DataContext;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }
    IFileSet<Post, Guid> Posts { get; }

    ValueTask SaveChangesAsync();
}