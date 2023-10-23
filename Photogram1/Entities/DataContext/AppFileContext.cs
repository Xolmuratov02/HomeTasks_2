using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileEntry;
using FileBaseContext.Abstractions.Models.FileSet;
using FileBaseContext.Context.Models.Configurations;
using FileBaseContext.Context.Models.FileContext;
using Photogram1.Models;
using System.Security.Principal;

namespace Photogram1.Entities.DataContext;

public class AppFileContext : FileContext, IDataContext
{
    public IFileSet<User, Guid> Users => Set<User, Guid>(nameof(Users));
    public IFileSet<Post, Guid> Posts => Set<Post, Guid>(nameof(Posts));

    public AppFileContext(IFileContextOptions<AppFileContext> fileContextOptions) : base(fileContextOptions)
    {
        OnSaveChanges += AddPrimaryKeys;
    }

    public ValueTask AddPrimaryKeys(IEnumerable<IFileSetBase> fileSets)
    {
        foreach (var fileSet in fileSets)
            foreach (var entry in fileSet.GetEntries())
            {
                if (entry is not IFileEntityEntry<IEntity> entityEntry) continue;

                if (entityEntry.State == FileEntityState.Added)
                    entityEntry.Entity.Id = Guid.NewGuid();

                if (entry is not IFileEntityEntry<IFileSetEntity<Guid>>) continue;
            }

        return new ValueTask(Task.CompletedTask);
    }
}