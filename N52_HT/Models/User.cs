using System.Net.Mail;

namespace N52_HT.Models;

public class User
{
    internal MailAddress EmailAddress;

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string firstName, string lastName, string email, string password)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }
}