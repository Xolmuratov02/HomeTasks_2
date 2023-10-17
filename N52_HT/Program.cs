//N52-HT1

//- dasturda user qo'shilgan payti userga email jo'natish kerak
//- buni user yoki email service ichida qilish mumkinmas
//- buning uchun user foundations service, email sender service va account orchestration service dan foydalaning
//- bunda o'rtada eventlarni ushlab turuchi AccountEventStore modeli ham bo'lsin
//- userlar qo'shilganda shu event store orqali OnUserCreated event chaqirilsin
//- AccountNotificationService da esa shu event uchun handler yozing
//- bu handler Email Sender service dan foydalanib, userga welcome email jo'natsin


