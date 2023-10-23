//N55-HT1

//- Console application yarating
//- asosiy project build papkasi ichiga ( bin/Debug/.net7 ) bir nechta folder va filelar copy qiling
//- asosiy project papkasi ichida nechta folder va fayl borligini
//- fayllar umumiy hajmi ( size ) va eng katta fayl qaysi ekanligini qaytaradigan service va methodlar
// yozing ( nomlarini o'zingiz o'ylab ko'ring ) 
//- tepada aytilgan ma'lumotlarni ekranga chiqaring

using N55_HT;

var Amount = FileFolderService.GetAmountOfEntries();
var size = FileFolderService.GetSizeOfFiles();
Console.WriteLine($"Count of\nEntries - {Amount.EntiresCount}\nFolders - {Amount.FoldersCount}\nFiles - {Amount.FilesCount}");
Console.WriteLine($"\nAll size of files - {size.AllSize}\nMax size of files - {size.MaxSize}");