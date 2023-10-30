//N62-HT1

//- emtpy web api project yarating
//- unga AuthController controllerini yarating va unga Login methodiini qo'shing
//- access token generate qilish uchun TokenGeneratorService yarating
//- Login methodida User modeli qabul qilib, TokenGeneratorService orqali token yaratib, yaratilgan tokenni Ok rezultati bilan qaytaring

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
