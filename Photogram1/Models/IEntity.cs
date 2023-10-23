using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileSet;

namespace Photogram1.Models
{
    public interface IEntity : IFileSetEntity<Guid>
    {
    }
}