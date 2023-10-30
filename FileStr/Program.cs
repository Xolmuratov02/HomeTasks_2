//N59-HT1

//- file storage api da drive lar uchun endpoint qo'shing
//- bunda xuddi directory ga o'xshab drivelar uchun alohida model bo'lsina
//- endpoint bunday bo'ladi - api/drives - bu barcha drive ma'lumotlarini olib kelsin
//- drive modelini tayyor API dan ko'rib olishingiz mumkin ( file explorer ichida FileExplorer.Api mavjud )

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
