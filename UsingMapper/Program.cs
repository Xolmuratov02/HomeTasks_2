using Sharprompt;
using UsingMapper;
using UsingMapper.DTOs;

var service = new UserService();

while (true)
{
    var choose = Prompt.Select("Choose", new[] { "Create user", "Get users" });

    if (choose == "Create user")
    {
        var firstName = Prompt.Input<string>("Enter a firstname");
        var lastName = Prompt.Input<string>("Enter a lastname");
        var email = Prompt.Input<string>("Enter a email");
        var password = Prompt.Input<string>("Enter a password");
        var userName = Prompt.Input<string>("Enter a username");

        var user = new UserForCreation()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password,
            UserName = userName
        };

        service.Create(user);
    }
    else if (choose == "Get users")
    {
        var users = service.GetUsers();

        foreach (var user in users)
            Console.WriteLine($"{user.FirstName} {user.LastName} - {user.UserName}");
    }
}