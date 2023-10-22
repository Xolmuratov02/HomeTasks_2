using N52_HT.Models;
using N52_HT.Services.Interfaces;
using System.Net.Mail;
using System.Net;

namespace N52_HT.Services;

public class EmailSenderService : IEmailSenderService
{
    public SmtpClient SmtpClientInstance { get; init; }

    public EmailSenderService()
    {
        SmtpClientInstance = new SmtpClient("smtp.gmail.com", 587);
        SmtpClientInstance.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        SmtpClientInstance.EnableSsl = true;
    }

    public async ValueTask<bool> SendEmailAsync(User user)
    {
        var result = true;
        try
        {
            var mail = new MailMessage("xolmuratovqurbonali@gmail.com", user.EmailAddress);
            mail.Subject = "Welcome!";
            mail.Body = "{{FullName}}!, welcome to our site!".Replace("{{FullName}}", $"{user.FirstName} {user.LastName}");

            await SmtpClientInstance.SendMailAsync(mail);
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }
}