using DemoApp.DTOs;
using DemoApp.Models;
using Mapster;

namespace DemoApp.Services;

public class UserService
{
    private IList<User> _users = new List<User>();

    public User Create(User user)
    {
        var existsUser = _users.FirstOrDefault(user => user.Email == user.Email);

        if (existsUser != null)
        {
            Console.WriteLine("User already exists!");
            return existsUser;
        }

     /*   var newUser = user.Adapt<User>();*/
        /*newUser.Id = Guid.NewGuid();*/

        _users.Add(user);

        return user;
    }
    
    public User GetUser(Guid id) => _users.FirstOrDefault(user => user.Id == id);
}