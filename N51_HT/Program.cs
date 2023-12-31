﻿//N51-HT1

//- buyurtmalar(Order) va bitta order ichidagi sotib olingan tovarlar ( Product ) uchun endpoint qanday bo'lishligi kerak?
//- web api konfiguratsiyasi uchun yaratilgan fayllar qaysi layerda turishligi kerak?
//- controller ichida nechta service inject qilish mumkin?
//- controller ichida foundations service larini ishlatish mumkinmi?

//Endpointlar yaratish:
//Controllers ichida Orderlar va Productlar uchun endpointlar (misol: OrderController va
//ProductController) yaratishimiz kerak. Bu endpointlar qaysi URL'lar orqali chaqirilishi kerakligini
//aniqlash uchun dekoretorlar bilan belgilanadi.

//Konfiguratsiya yaratish:
//Startup.cs faylida ConfigureServices va Configure metodlarini ishlatib, konfiguratsiyani sozlashimiz
//mumkin. Bu yerda siz Entity Framework, JWT avtorizatsiyasi, CORS, va boshqa konfiguratsiya sozlamalarni
//sozlay olamiz.

//Services va Models:
//Services layerida Orderlar va Productlar uchun xizmatlarni yaratishimiz va bularni controllerlar
//orqali chaqirishimiz kerak. Models layerida Orderlar va Productlar uchun klasslarni yaratishimiz kerak.

//Dependency Injection (DI):
//Controllerlar ichida ishlatiladigan xizmatlarni injekt qilishimiz kerak. Bu, services layeridagi
//xizmatlarni controllerlarda ishlatish imkoniyatini beradi.

//Foundation services:
//Ha, biz controllers ichida foundation services yaratib ishlatishimiz mumkin. Bularni services
//layerida yaratib, bu xizmatlarni controllerlarda yoki boshqa joylarda ishlatishimiz mumkin.