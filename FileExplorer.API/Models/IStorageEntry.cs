namespace FileExplorer.API.Models;

public interface IStorageEntry
{
    string Path { get; set; }

    StorageItemType ItemType { get; set; }
}