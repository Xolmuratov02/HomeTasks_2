namespace FileExplorer.API.Models;

public class StorageDirectory : IStorageEntry
{
    public StorageDirectory()
    {
        if (Directory.Exists(""))
            throw new Exception();
    }

    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public long ItemsCount { get; set; }
    public StorageItemType ItemType { get; set; } = StorageItemType.Directory;
}