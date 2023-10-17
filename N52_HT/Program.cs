//N52-HT1

//- dasturda user qo'shilgan payti userga email jo'natish kerak
//- buni user yoki email service ichida qilish mumkinmas
//- buning uchun user foundations service, email sender service va account orchestration service dan foydalaning
//- bunda o'rtada eventlarni ushlab turuchi AccountEventStore modeli ham bo'lsin
//- userlar qo'shilganda shu event store orqali OnUserCreated event chaqirilsin
//- AccountNotificationService da esa shu event uchun handler yozing
//- bu handler Email Sender service dan foydalanib, userga welcome email jo'natsin


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