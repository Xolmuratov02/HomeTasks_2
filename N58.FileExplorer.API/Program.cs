//N58-HT1

//- file explorer uchun API qiling
//- bunda Directory va File dan foydalanish uchun Broker lardan foydalaning
//- sizda bitta endpoint bo'ladi - api/directories/root/entries
//- bu endpoint wwwroot ( static fayllar turadigan joy ) dagi directorylar va fayllar haqida ma'lumot qaytaradi
//- directory va faylni serialize qilib bo'lmaydi va shuning uchun bunga boshqa modellardan foydalanasiz, masalan StorageDirectory va StorageFile

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
