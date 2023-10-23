namespace FileExplorer.Application.FileStorage.Models;

public class StorageDrive : IStorageEntry
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;

}